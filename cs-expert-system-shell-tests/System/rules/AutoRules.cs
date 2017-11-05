using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem
{
    static class AutoRules
    {
        static public RuleInferenceEngine getInferenceEngine()
        {
            RuleInferenceEngine rie = new RuleInferenceEngine();

            Rule rule = new Rule("Bicycle");
            rule.AddAntecedent(new IsClause("type", "cycle"));
            rule.AddAntecedent(new IsClause("есть мотор", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "велосипед"));
            rie.AddRule(rule);

            rule = new Rule("Motorcycle");
            rule.AddAntecedent(new IsClause("type", "cycle"));
            rule.AddAntecedent(new IsClause("колес", "2"));
            rule.AddAntecedent(new IsClause("есть мотор", "Да"));
            rule.setConsequent(new IsClause("vehicle", "мотоцикл"));
            rie.AddRule(rule);

            rule = new Rule("Tricycle");
            rule.AddAntecedent(new IsClause("type", "cycle"));
            rule.AddAntecedent(new IsClause("колес", "3"));
            rule.AddAntecedent(new IsClause("есть мотор", "Да"));
            rule.setConsequent(new IsClause("vehicle", "трицикл"));
            rie.AddRule(rule);

            rule = new Rule("ATV");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new LessClause("дверей", "2"));
            rule.AddAntecedent(new IsClause("колес", "4"));
            rule.setConsequent(new IsClause("vehicle", "ATV"));
            rie.AddRule(rule);

            rule = new Rule("Minivan");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new GreaterClause("посадочных мест", "5"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.setConsequent(new IsClause("vehicle", "минивен"));
            rie.AddRule(rule);

            rule = new Rule("MPV");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new GreaterClause("посадочных мест", "5"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Да"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.setConsequent(new IsClause("vehicle", "MPV"));
            rie.AddRule(rule);

            rule = new Rule("Van-passanger");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new GreaterClause("посадочных мест", "7"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "фургон"));
            rie.AddRule(rule);

            rule = new Rule("Van-MPV");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new GreaterClause("посадочных мест", "7"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Да"));
            rule.setConsequent(new IsClause("vehicle", "MPV"));
            rie.AddRule(rule);

            rule = new Rule("Targa");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("есть крыша", "Нет"));
            rule.AddAntecedent(new IsClause("жесткая крыша", "Нет"));
            rule.AddAntecedent(new IsClause("дверей", "2"));
            rule.setConsequent(new IsClause("vehicle", "тарга"));
            rie.AddRule(rule);

            rule = new Rule("Roadster");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("есть крыша", "Нет"));
            rule.AddAntecedent(new IsClause("жесткая крыша", "Да"));
            rule.AddAntecedent(new IsClause("дверей", "2"));
            rule.setConsequent(new IsClause("vehicle", "родстер"));
            rie.AddRule(rule);

            rule = new Rule("Coupe");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("есть крыша", "Да"));
            rule.AddAntecedent(new IsClause("дверей", "2"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "купе"));
            rie.AddRule(rule);

            rule = new Rule("Pickup-2");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("есть крыша", "Да"));
            rule.AddAntecedent(new IsClause("дверей", "2"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Да"));
            rule.setConsequent(new IsClause("vehicle", "пикап"));
            rie.AddRule(rule);

            rule = new Rule("Cabrio-Convertibles");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("есть крыша", "Нет"));
            rule.AddAntecedent(new GEClause("дверей", "3"));
            rule.setConsequent(new IsClause("vehicle", "кабриолет"));
            rie.AddRule(rule);

            rule = new Rule("Limo");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "4"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "лимузин"));
            rie.AddRule(rule);

            rule = new Rule("Pickup-4");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "4"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Да"));
            rule.setConsequent(new IsClause("vehicle", "пикап"));
            rie.AddRule(rule);

            rule = new Rule("Sedan");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "4"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "седан"));
            rie.AddRule(rule);

            rule = new Rule("Fastback");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "4"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Да"));
            rule.setConsequent(new IsClause("vehicle", "фастбэк"));
            rie.AddRule(rule);

            rule = new Rule("Wagon-3");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "3"));
            rule.AddAntecedent(new IsClause("размер", "Средний"));
            rule.setConsequent(new IsClause("vehicle", "унверсал"));
            rie.AddRule(rule);

            rule = new Rule("Wagon-5");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "5"));
            rule.AddAntecedent(new IsClause("размер", "Средний"));
            rule.setConsequent(new IsClause("vehicle", "унверсал"));
            rie.AddRule(rule);

            rule = new Rule("CUV-3");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "3"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.AddAntecedent(new IsClause("высокий дорожный просвет", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "кроссовер"));
            rie.AddRule(rule);

            rule = new Rule("CUV-5");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "5"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.AddAntecedent(new IsClause("высокий дорожный просвет", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "кроссовер"));
            rie.AddRule(rule);

            rule = new Rule("SUV-3");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "3"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.AddAntecedent(new IsClause("высокий дорожный просвет", "Да"));
            rule.setConsequent(new IsClause("vehicle", "джип"));
            rie.AddRule(rule);

            rule = new Rule("SUV-5");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "5"));
            rule.AddAntecedent(new IsClause("размер", "Большой"));
            rule.AddAntecedent(new IsClause("специальное место для груза", "Нет"));
            rule.AddAntecedent(new IsClause("высокий дорожный просвет", "Да"));
            rule.setConsequent(new IsClause("vehicle", "джип"));
            rie.AddRule(rule);

            rule = new Rule("Hatchback-3");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "3"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Да"));
            rule.setConsequent(new IsClause("vehicle", "хэтчбек"));
            rie.AddRule(rule);

            rule = new Rule("Hatchback-5");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "5"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Да"));
            rule.setConsequent(new IsClause("vehicle", "хэтчбек"));
            rie.AddRule(rule);

            rule = new Rule("Liftback-3");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "3"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "лифтбек"));
            rie.AddRule(rule);

            rule = new Rule("Liftback-5");
            rule.AddAntecedent(new IsClause("type", "automobile"));
            rule.AddAntecedent(new IsClause("дверей", "5"));
            rule.AddAntecedent(new IsClause("размер", "Маленький"));
            rule.AddAntecedent(new IsClause("задняя часть крыши спускается плавно", "Нет"));
            rule.setConsequent(new IsClause("vehicle", "лифтбек"));
            rie.AddRule(rule);

            rule = new Rule("Cycle");
            rule.AddAntecedent(new LessClause("колес", "4"));
            rule.setConsequent(new IsClause("type", "cycle"));
            rie.AddRule(rule);

            rule = new Rule("Automobile");
            rule.AddAntecedent(new IsClause("колес", "4"));
            rule.AddAntecedent(new IsClause("есть мотор", "Да"));
            rule.setConsequent(new IsClause("type", "automobile"));
            rie.AddRule(rule);

            return rie;
        }
    }
}
