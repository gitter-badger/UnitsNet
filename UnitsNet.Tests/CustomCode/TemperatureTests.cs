// Copyright © 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using NUnit.Framework;

namespace UnitsNet.Tests.CustomCode
{
    public class TemperatureTests : TemperatureTestsBase
    {
        private static readonly Temperature DegreesCelsius20 = Temperature.FromDegreesCelsius(20);
        private static readonly Temperature DegreesCelsius30 = Temperature.FromDegreesCelsius(30);
        private static readonly Temperature DegreesCelsius10 = Temperature.FromDegreesCelsius(10);
        private static readonly TemperatureDelta DegreesCelsiusDelta20 = TemperatureDelta.FromDegreesCelsiusDelta(20);

        protected override double DegreesCelsiusInOneKelvin => -272.15;

        protected override double DegreesDelisleInOneKelvin => 558.2249999999999;

        protected override double DegreesFahrenheitInOneKelvin => -457.87;

        protected override double DegreesNewtonInOneKelvin => -89.8095;

        protected override double DegreesRankineInOneKelvin => 1.8;

        protected override double DegreesReaumurInOneKelvin => -217.72;

        protected override double DegreesRoemerInOneKelvin => -135.378750000;

        protected override double KelvinsInOneKelvin => 1;

//        [Test]
//        public void DoubleMultipliedByTemperatureEqualsTemperature()
//        {
//            Assert.AreEqual(Temperature.FromDegreesCelsius(60), 3 * DegreesCelsius20);
//        }

        [Test]
        public void TemperatureDeltaPlusTemperatureEqualsTemperature()
        {
            Assert.AreEqual(Temperature.FromDegreesCelsius(30), DegreesCelsiusDelta20 + DegreesCelsius10);
        }

//        [Test]
//        public void TemperatureDividedByDoubleEqualsTemperature()
//        {
//            Assert.AreEqual(Temperature.FromDegreesCelsius(10), DegreesCelsius20 / 2);
//        }

        [Test]
        public void TemperatureMinusTemperatureDeltaEqualsTemperature()
        {
            Assert.AreEqual(Temperature.FromDegreesCelsius(10), DegreesCelsius30 - DegreesCelsiusDelta20);
        }

        [Test]
        public void TemperatureMinusTemperatureEqualsTemperatureDelta()
        {
            Assert.AreEqual(TemperatureDelta.FromDegreesCelsiusDelta(10), DegreesCelsius30 - DegreesCelsius20);
        }

//        [Test]
//        public void TemperatureMultipliedByDoubleEqualsTemperature()
//        {
//            Assert.AreEqual(Temperature.FromDegreesCelsius(60), DegreesCelsius20 * 3);
//        }

//        [Test]
//        public void TemperatureNegatedEqualsTemperature()
//        {
//            Assert.AreEqual(Temperature.FromDegreesCelsius(-10), -DegreesCelsius10);
//        }

        [Test]
        public void TemperaturePlusTemperatureDeltaEqualsTemperature()
        {
            Assert.AreEqual(Temperature.FromDegreesCelsius(30), DegreesCelsius10 + DegreesCelsiusDelta20);
        }
    }
}