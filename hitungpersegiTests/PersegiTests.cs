using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[TestFixture]
public class PersegiTests
{
    [TestCase(5, 25, 20)]
    [TestCase(3, 9, 12)]
    [TestCase(0, 0, 0)] // Test case for zero side length
    public void HitungLuas_DiberikanSisiMengembalikanLuas(double sisi, double expectedLuas, double expectedKeliling)
    {
        Persegi persegi = new Persegi { Sisi = sisi };

        double actualLuas = persegi.HitungLuas();

        NUnit.Framework.Assert.AreEqual(expectedLuas, actualLuas);
    }

    [TestCase(5, 20, 20)]
    [TestCase(3, 12, 12)]
    [TestCase(0, 0, 0)] // Test case for zero side length
    public void HitungKeliling_DiberikanSisiMengembalikanKeliling(double sisi, double expectedLuas, double expectedKeliling)
    {
        Persegi persegi = new Persegi { Sisi = sisi };

        double actualKeliling = persegi.HitungKeliling();

        NUnit.Framework.Assert.AreEqual(expectedKeliling, actualKeliling);
    }
}