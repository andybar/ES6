using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using ExpertSystem;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }


        private Thread expert;
        private ManualResetEvent nextEvent = new ManualResetEvent(false);
        private ManualResetEvent readyEvent = new ManualResetEvent(false);
        private List<string> answers_list = new List<string>();
        private bool number_value = false;
        private string answer = "";
        private string question = "";
        private bool finished = false;
        private Clause conclusion = null;


        private void SetForm()
        {
            if (!finished)
            {
                labelQuestion.Text = question;
                labelResult.Text = "";
                buttonNext.Visible = true;
                buttonReload.Visible = false;

                if (number_value)
                {
                    textBoxAnswers.Visible = true;
                    textBoxAnswers.Text = "";
                    comboBoxAnswers.Visible = false;
                }
                else
                {
                    textBoxAnswers.Visible = false;
                    comboBoxAnswers.Items.Clear();
                    comboBoxAnswers.Items.AddRange(answers_list.ToArray());
                    comboBoxAnswers.SelectedIndex = 0;
                    comboBoxAnswers.Visible = true;
                }

                buttonNext.Enabled = true;
            }
            else
            {
                labelQuestion.Text = "";
                if (conclusion != null)
                {
                    labelResult.Text = "Загаданное ТС - " + conclusion.Value;
                }
                else
                {
                    labelResult.Text = "Не удалось разгадать :(";
                }
                textBoxAnswers.Visible = false;
                comboBoxAnswers.Visible = false;
                buttonNext.Visible = false;
                buttonReload.Visible = true;
            }
        }
        private void ExpertCycle()
        {
            RuleInferenceEngine rie = AutoRules.getInferenceEngine();
            rie.ClearFacts();

            List<Clause> unproved_conditions = new List<Clause>();

            conclusion = null;
            while (conclusion == null)
            {
                conclusion = rie.Infer("vehicle", unproved_conditions);
                if (conclusion == null)
                {
                    if (unproved_conditions.Count == 0)
                    {
                        break;
                    }
                    Clause c = unproved_conditions[0];

                    number_value = false;

                    for (int i = 0; i < rie.m_rules.Count(); i++)
                    {
                        if (number_value == true)
                        {
                            break;
                        }
                        for (int j = 0; j < rie.m_rules[i].m_antecedents.Count(); j++)
                        {

                            if (rie.m_rules[i].m_antecedents[j].Variable == c.Variable)
                            {
                                if (rie.m_rules[i].m_antecedents[j].Condition != "=")
                                {
                                    number_value = true;
                                    break;
                                }
                                else
                                {
                                    if (!answers_list.Contains(rie.m_rules[i].m_antecedents[j].Value))
                                    {
                                        answers_list.Add(rie.m_rules[i].m_antecedents[j].Value);
                                    }
                                }
                            }
                        }
                    }
                    if (number_value)
                    {
                        question = "У данного ТС сколько " + c.Variable + "?";
                    }
                    else
                    {
                        question = "У данного ТС " + c.Variable + "?";
                    }
                    //Console.WriteLine("ask: " + c + "?");
                    //question = "What is " + c.Variable + "?";
                    readyEvent.Set();
                    nextEvent.Reset();
                    unproved_conditions.Clear();
                    nextEvent.WaitOne();
                    answers_list.Clear();
                    //Console.WriteLine("What is " + c.Variable + "?");
                    String value = answer;//Console.ReadLine();
                    rie.AddFact(new IsClause(c.Variable, value));
                }
            }
            readyEvent.Set();
            finished = true;
            //Console.WriteLine("Conclusion: " + conclusion);
            //Console.WriteLine("Memory: ");
            //Console.WriteLine("{0}", rie.Facts);
            //Console.ReadLine();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            buttonNext.Enabled = false;
            readyEvent.Reset();
            if (number_value)
            {
                answer = textBoxAnswers.Text;
            }
            else
            {
                answer = comboBoxAnswers.SelectedItem.ToString();
            }
            nextEvent.Set();
            readyEvent.WaitOne();
            SetForm();
        }

        private void StartGame()
        {
            finished = false;
            readyEvent.Reset();
            expert = new Thread(ExpertCycle);
            expert.Start();
            readyEvent.WaitOne();
            SetForm();
            
        }

        private void Form_Load(object sender, EventArgs e)
        {
            StartGame();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            expert.Abort();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            StartGame();
            JustificationSingleton.Clear();
        }

        private void JustificationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void JustificationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(JustificationSingleton.justificationBuffer);
        }
    }
}
