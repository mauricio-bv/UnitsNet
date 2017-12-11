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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
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

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToMolarEntropy
{
    public static class NumberToMolarEntropyExtensions
    {
        #region JoulePerMoleKelvin

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double)"/>
        public static MolarEntropy JoulesPerMoleKelvin(this int value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? JoulesPerMoleKelvin(this int? value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double)"/>
        public static MolarEntropy JoulesPerMoleKelvin(this long value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? JoulesPerMoleKelvin(this long? value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double)"/>
        public static MolarEntropy JoulesPerMoleKelvin(this double value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? JoulesPerMoleKelvin(this double? value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double)"/>
        public static MolarEntropy JoulesPerMoleKelvin(this float value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? JoulesPerMoleKelvin(this float? value) => MolarEntropy.FromJoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double)"/>
        public static MolarEntropy JoulesPerMoleKelvin(this decimal value) => MolarEntropy.FromJoulesPerMoleKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarEntropy.FromJoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? JoulesPerMoleKelvin(this decimal? value) => MolarEntropy.FromJoulesPerMoleKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilojoulePerMoleKelvin

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double)"/>
        public static MolarEntropy KilojoulesPerMoleKelvin(this int value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? KilojoulesPerMoleKelvin(this int? value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double)"/>
        public static MolarEntropy KilojoulesPerMoleKelvin(this long value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? KilojoulesPerMoleKelvin(this long? value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double)"/>
        public static MolarEntropy KilojoulesPerMoleKelvin(this double value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? KilojoulesPerMoleKelvin(this double? value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double)"/>
        public static MolarEntropy KilojoulesPerMoleKelvin(this float value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? KilojoulesPerMoleKelvin(this float? value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double)"/>
        public static MolarEntropy KilojoulesPerMoleKelvin(this decimal value) => MolarEntropy.FromKilojoulesPerMoleKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarEntropy.FromKilojoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? KilojoulesPerMoleKelvin(this decimal? value) => MolarEntropy.FromKilojoulesPerMoleKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegajoulePerMoleKelvin

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double)"/>
        public static MolarEntropy MegajoulesPerMoleKelvin(this int value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? MegajoulesPerMoleKelvin(this int? value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double)"/>
        public static MolarEntropy MegajoulesPerMoleKelvin(this long value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? MegajoulesPerMoleKelvin(this long? value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double)"/>
        public static MolarEntropy MegajoulesPerMoleKelvin(this double value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? MegajoulesPerMoleKelvin(this double? value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double)"/>
        public static MolarEntropy MegajoulesPerMoleKelvin(this float value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? MegajoulesPerMoleKelvin(this float? value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value);

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double)"/>
        public static MolarEntropy MegajoulesPerMoleKelvin(this decimal value) => MolarEntropy.FromMegajoulesPerMoleKelvin(Convert.ToDouble(value));

        /// <inheritdoc cref="MolarEntropy.FromMegajoulesPerMoleKelvin(double?)"/>
        public static MolarEntropy? MegajoulesPerMoleKelvin(this decimal? value) => MolarEntropy.FromMegajoulesPerMoleKelvin(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif