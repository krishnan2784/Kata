﻿using NUnit.Framework;

namespace Kata.Test
{
    [TestFixture]
    public class FactorialCalculatorShould
    {
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(2, ExpectedResult = "2")]
        [TestCase(169, ExpectedResult = "42690680090047026720062648805820850387756975875746245047606552641771041861638240560617636629151816857409132566202994395836167476759353273143605880851692806242768458117639325189454779548336505175152773372238945176444516224321575248351285305864915204686974405930350609429121563777253758476415021841813340160")]
        [TestCase(101, ExpectedResult = "9425947759838353638138390835342801376610975723095888339920014242478768251047951733961834230251772401385381873852523273511991274827736142409989069734354272387072")]
        [TestCase(120, ExpectedResult = "6689502913449123933681342530579439120523775756341546089360093784620090324126011858610763674005344861930779387322735825049576193801545269664994272835560837966773424760538449951889918907707412713570304")]

        public string FactorialTest(int n)
        {
            return Kata.Domain.FactorialCalculator.Factorial(n);
        }
    }
}