﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of AreaMomentOfInertia.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AreaMomentOfInertiaTestsBase
    {
        protected abstract double CentimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double DecimetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double FeetToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double InchesToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double MetersToTheFourthInOneMeterToTheFourth { get; }
        protected abstract double MillimetersToTheFourthInOneMeterToTheFourth { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double DecimetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double FeetToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double InchesToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double MetersToTheFourthTolerance { get { return 1e-5; } }
        protected virtual double MillimetersToTheFourthTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaMomentOfInertia((double)0.0, AreaMomentOfInertiaUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AreaMomentOfInertia();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaMomentOfInertia(double.PositiveInfinity, AreaMomentOfInertiaUnit.MeterToTheFourth));
            Assert.Throws<ArgumentException>(() => new AreaMomentOfInertia(double.NegativeInfinity, AreaMomentOfInertiaUnit.MeterToTheFourth));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaMomentOfInertia(double.NaN, AreaMomentOfInertiaUnit.MeterToTheFourth));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AreaMomentOfInertia(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void AreaMomentOfInertia_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth);

            QuantityInfo<AreaMomentOfInertiaUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AreaMomentOfInertia.Zero, quantityInfo.Zero);
            Assert.Equal("AreaMomentOfInertia", quantityInfo.Name);
            Assert.Equal(QuantityType.AreaMomentOfInertia, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<AreaMomentOfInertiaUnit>().Except(new[] {AreaMomentOfInertiaUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void MeterToTheFourthToAreaMomentOfInertiaUnits()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, metertothefourth.CentimetersToTheFourth, CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, metertothefourth.DecimetersToTheFourth, DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, metertothefourth.FeetToTheFourth, FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, metertothefourth.InchesToTheFourth, InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, metertothefourth.MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, metertothefourth.MillimetersToTheFourth, MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity00.CentimetersToTheFourth, CentimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.CentimeterToTheFourth, quantity00.Unit);

            var quantity01 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity01.DecimetersToTheFourth, DecimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.DecimeterToTheFourth, quantity01.Unit);

            var quantity02 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.FootToTheFourth);
            AssertEx.EqualTolerance(1, quantity02.FeetToTheFourth, FeetToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.FootToTheFourth, quantity02.Unit);

            var quantity03 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.InchToTheFourth);
            AssertEx.EqualTolerance(1, quantity03.InchesToTheFourth, InchesToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.InchToTheFourth, quantity03.Unit);

            var quantity04 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity04.MetersToTheFourth, MetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, quantity04.Unit);

            var quantity05 = AreaMomentOfInertia.From(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth);
            AssertEx.EqualTolerance(1, quantity05.MillimetersToTheFourth, MillimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MillimeterToTheFourth, quantity05.Unit);

        }

        [Fact]
        public void FromMetersToTheFourth_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaMomentOfInertia.FromMetersToTheFourth(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AreaMomentOfInertia.FromMetersToTheFourth(double.NegativeInfinity));
        }

        [Fact]
        public void FromMetersToTheFourth_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaMomentOfInertia.FromMetersToTheFourth(double.NaN));
        }

        [Fact]
        public void As()
        {
            var metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.CentimeterToTheFourth), CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.DecimeterToTheFourth), DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.FootToTheFourth), FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.InchToTheFourth), InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.MeterToTheFourth), MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, metertothefourth.As(AreaMomentOfInertiaUnit.MillimeterToTheFourth), MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);

            var centimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.CentimeterToTheFourth);
            AssertEx.EqualTolerance(CentimetersToTheFourthInOneMeterToTheFourth, (double)centimetertothefourthQuantity.Value, CentimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.CentimeterToTheFourth, centimetertothefourthQuantity.Unit);

            var decimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.DecimeterToTheFourth);
            AssertEx.EqualTolerance(DecimetersToTheFourthInOneMeterToTheFourth, (double)decimetertothefourthQuantity.Value, DecimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.DecimeterToTheFourth, decimetertothefourthQuantity.Unit);

            var foottothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.FootToTheFourth);
            AssertEx.EqualTolerance(FeetToTheFourthInOneMeterToTheFourth, (double)foottothefourthQuantity.Value, FeetToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.FootToTheFourth, foottothefourthQuantity.Unit);

            var inchtothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.InchToTheFourth);
            AssertEx.EqualTolerance(InchesToTheFourthInOneMeterToTheFourth, (double)inchtothefourthQuantity.Value, InchesToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.InchToTheFourth, inchtothefourthQuantity.Unit);

            var metertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.MeterToTheFourth);
            AssertEx.EqualTolerance(MetersToTheFourthInOneMeterToTheFourth, (double)metertothefourthQuantity.Value, MetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MeterToTheFourth, metertothefourthQuantity.Unit);

            var millimetertothefourthQuantity = metertothefourth.ToUnit(AreaMomentOfInertiaUnit.MillimeterToTheFourth);
            AssertEx.EqualTolerance(MillimetersToTheFourthInOneMeterToTheFourth, (double)millimetertothefourthQuantity.Value, MillimetersToTheFourthTolerance);
            Assert.Equal(AreaMomentOfInertiaUnit.MillimeterToTheFourth, millimetertothefourthQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromCentimetersToTheFourth(metertothefourth.CentimetersToTheFourth).MetersToTheFourth, CentimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromDecimetersToTheFourth(metertothefourth.DecimetersToTheFourth).MetersToTheFourth, DecimetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromFeetToTheFourth(metertothefourth.FeetToTheFourth).MetersToTheFourth, FeetToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromInchesToTheFourth(metertothefourth.InchesToTheFourth).MetersToTheFourth, InchesToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromMetersToTheFourth(metertothefourth.MetersToTheFourth).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(1, AreaMomentOfInertia.FromMillimetersToTheFourth(metertothefourth.MillimetersToTheFourth).MetersToTheFourth, MillimetersToTheFourthTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AreaMomentOfInertia v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AssertEx.EqualTolerance(-1, -v.MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (AreaMomentOfInertia.FromMetersToTheFourth(3)-v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (v + v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(10, (v*10).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(10, (10*v).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, (AreaMomentOfInertia.FromMetersToTheFourth(10)/5).MetersToTheFourth, MetersToTheFourthTolerance);
            AssertEx.EqualTolerance(2, AreaMomentOfInertia.FromMetersToTheFourth(10)/AreaMomentOfInertia.FromMetersToTheFourth(5), MetersToTheFourthTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AreaMomentOfInertia oneMeterToTheFourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            AreaMomentOfInertia twoMetersToTheFourth = AreaMomentOfInertia.FromMetersToTheFourth(2);

            Assert.True(oneMeterToTheFourth < twoMetersToTheFourth);
            Assert.True(oneMeterToTheFourth <= twoMetersToTheFourth);
            Assert.True(twoMetersToTheFourth > oneMeterToTheFourth);
            Assert.True(twoMetersToTheFourth >= oneMeterToTheFourth);

            Assert.False(oneMeterToTheFourth > twoMetersToTheFourth);
            Assert.False(oneMeterToTheFourth >= twoMetersToTheFourth);
            Assert.False(twoMetersToTheFourth < oneMeterToTheFourth);
            Assert.False(twoMetersToTheFourth <= oneMeterToTheFourth);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Equal(0, metertothefourth.CompareTo(metertothefourth));
            Assert.True(metertothefourth.CompareTo(AreaMomentOfInertia.Zero) > 0);
            Assert.True(AreaMomentOfInertia.Zero.CompareTo(metertothefourth) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Throws<ArgumentException>(() => metertothefourth.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.Throws<ArgumentNullException>(() => metertothefourth.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            var b = AreaMomentOfInertia.FromMetersToTheFourth(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = AreaMomentOfInertia.FromMetersToTheFourth(1);
            var b = AreaMomentOfInertia.FromMetersToTheFourth(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.True(v.Equals(AreaMomentOfInertia.FromMetersToTheFourth(1), MetersToTheFourthTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AreaMomentOfInertia.Zero, MetersToTheFourthTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.False(metertothefourth.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AreaMomentOfInertia metertothefourth = AreaMomentOfInertia.FromMetersToTheFourth(1);
            Assert.False(metertothefourth.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AreaMomentOfInertiaUnit.Undefined, AreaMomentOfInertia.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AreaMomentOfInertiaUnit)).Cast<AreaMomentOfInertiaUnit>();
            foreach(var unit in units)
            {
                if(unit == AreaMomentOfInertiaUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AreaMomentOfInertia.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth).ToString());
                Assert.Equal("1 dm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth).ToString());
                Assert.Equal("1 ft⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.FootToTheFourth).ToString());
                Assert.Equal("1 in⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.InchToTheFourth).ToString());
                Assert.Equal("1 m⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString());
                Assert.Equal("1 mm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.CentimeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 dm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.DecimeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 ft⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.FootToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 in⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.InchToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 m⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString(swedishCulture));
            Assert.Equal("1 mm⁴", new AreaMomentOfInertia(1, AreaMomentOfInertiaUnit.MillimeterToTheFourth).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s1"));
                Assert.Equal("0.12 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s2"));
                Assert.Equal("0.123 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s3"));
                Assert.Equal("0.1235 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s1", culture));
            Assert.Equal("0.12 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s2", culture));
            Assert.Equal("0.123 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s3", culture));
            Assert.Equal("0.1235 m⁴", new AreaMomentOfInertia(0.123456, AreaMomentOfInertiaUnit.MeterToTheFourth).ToString("s4", culture));
        }
    }
}
