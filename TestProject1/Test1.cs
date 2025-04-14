using Microsoft.VisualStudio.TestTools.UnitTesting;
using TooniiMachine.Undsen;  // BasicCalculator-ийн байршиж буй namespace

namespace ConsoleApp12.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // Тест бүрийн өмнө дуудагдах тохиргоо байвал энд бичнэ
        }

        [TestMethod]
        public void EyregTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(5);

            Assert.AreEqual(5, calculator.Result, "5 нэмэхэд үр дүн 5 байх ёстой.");
        }

        [TestMethod]
        public void OlonEyregTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(5);
            calculator.Add(10);

            Assert.AreEqual(15, calculator.Result, "5 + 10 = 15 байх ёстой.");
        }

        [TestMethod]
        public void SurugTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(-7);

            Assert.AreEqual(-7, calculator.Result, "-7 нэмэхэд үр дүн -7 байх ёстой.");
        }

        [TestMethod]
        public void eyreg_sorogTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(10);
            calculator.Add(-3);

            Assert.AreEqual(7, calculator.Result, "10 + (-3) = 7 байх ёстой.");
        }

        [TestMethod]
        public void TegTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(0);

            Assert.AreEqual(0, calculator.Result, "0 нэмэхэд үр дүн 0 байх ёстой.");
        }

        [TestMethod]
        public void OlonEyregSurugTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(10);
            calculator.Add(0);
            calculator.Add(5);
            calculator.Add(-2);

            Assert.AreEqual(13, calculator.Result, "10 + 0 + 5 + (-2) = 13 байх ёстой.");
        }

        [TestMethod]
        public void TomTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(1000000);
            calculator.Add(2000000);

            Assert.AreEqual(3000000, calculator.Result, "Том тоонуудын нийлбэр 3,000,000 байх ёстой.");
        }

        [TestMethod]
        public void EyregSurugToonTentsuuTooNemeh()
        {
            var calculator = new BasicCalculator();

            calculator.Add(-8);
            calculator.Add(8);

            Assert.AreEqual(0, calculator.Result, "-8 + 8 = 0 байх ёстой.");
        }
        [TestMethod]
        public void NegTooHasah()
        {
            var calculator = new BasicCalculator();
            calculator.Subtract(3);
            Assert.AreEqual(-3, calculator.Result, "0 - 3 = -3 байх ёстой.");
        }

        [TestMethod]
        public void OlonEyregTooHasah()
        {
            var calculator = new BasicCalculator();
            calculator.Add(20);         // эхэлж 20 болгоно
            calculator.Subtract(5);
            calculator.Subtract(10);
            Assert.AreEqual(5, calculator.Result, "20 - 5 - 10 = 5 байх ёстой.");
        }

        [TestMethod]
        public void SurugTooHasah()
        {
            var calculator = new BasicCalculator();
            calculator.Subtract(-10);
            Assert.AreEqual(10, calculator.Result, "0 - (-10) = 10 байх ёстой.");
        }
        [TestMethod]
        public void EyregTooUrjih()
        {
            var calculator = new BasicCalculator();
            calculator.Add(5);          // эхний утга
            calculator.Multiply(3);     // 5 * 3 = 15
            Assert.AreEqual(15, calculator.Result);
        }

        [TestMethod]
        public void TegTooUrjih()
        {
            var calculator = new BasicCalculator();
            calculator.Add(100);
            calculator.Multiply(0);
            Assert.AreEqual(0, calculator.Result, "Ямар ч тоог 0-ээр үржүүлэхэд 0 байх ёстой.");
        }

        [TestMethod]
        public void HasahTooUrjih()
        {
            var calculator = new BasicCalculator();
            calculator.Add(7);
            calculator.Multiply(-2);
            Assert.AreEqual(-14, calculator.Result);
        }
        [TestMethod]
        public void EyregTooHuwaah()
        {
            var calculator = new BasicCalculator();
            calculator.Add(10);
            calculator.Divide(2);   // 10 / 2 = 5
            Assert.AreEqual(5, calculator.Result);
        }

        [TestMethod]
        public void SurugTooHuwaah()
        {
            var calculator = new BasicCalculator();
            calculator.Add(9);
            calculator.Divide(-3);  // 9 / -3 = -3
            Assert.AreEqual(-3, calculator.Result);
        }

        [TestMethod]
        public void NegdHuwaah()
        {
            var calculator = new BasicCalculator();
            calculator.Add(123);
            calculator.Divide(1);
            Assert.AreEqual(123, calculator.Result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TegToondHuwaah()
        {
            var calculator = new BasicCalculator();
            calculator.Add(5);
            calculator.Divide(0);  // 0-р хуваах үед алдаа гаргах ёстой
        }
        [TestMethod]
        public void MemorySave_SavesCurrentResult()
        {
            var calculator = new BasicCalculator();
            calculator.Add(50);
            calculator.MemorySave();

            // Энэ үед дотоод санамжинд 50 хадгалагдсан байх ёстой
            calculator.Reset();  // Result-г тэг болгоод...
            calculator.MemoryRecall();  // ...хадгалсан утгаа сэргээх

            Assert.AreEqual(50, calculator.Result, "MemorySave болон MemoryRecall зөв ажиллаж байгаа эсэх.");
        }

        [TestMethod]
        public void MemoryClear_ResetsMemory()
        {
            var calculator = new BasicCalculator();
            calculator.Add(20);
            calculator.MemorySave();
            calculator.MemoryClear();   // хадгалсан утгыг арилгана

            calculator.Reset();
            calculator.MemoryRecall();  // сэргээх үед 0 буцах ёстой

            Assert.AreEqual(0, calculator.Result, "MemoryClear дараа сэргээхэд 0 буцах ёстой.");
        }

        [TestMethod]
        public void MemoryRecall_WithoutSaving_ReturnsZero()
        {
            var calculator = new BasicCalculator();
            calculator.MemoryRecall();

            Assert.AreEqual(0, calculator.Result, "Хадгалаагүй үед сэргээхэд 0 байх ёстой.");
        }

        [TestMethod]
        public void MemoryOverwrite_ReplacesOldMemory()
        {
            var calculator = new BasicCalculator();
            calculator.Add(30);
            calculator.MemorySave();     // 30 хадгална

            calculator.Reset();
            calculator.Add(99);
            calculator.MemorySave();     // өмнөхийг 99-р дарна

            calculator.Reset();
            calculator.MemoryRecall();   // 99-г сэргээх ёстой

            Assert.AreEqual(99, calculator.Result);
        }

    }
}
