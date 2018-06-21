
//------------------------------------------------------------------------------
// This code was generated by a tool.
//
//   Tool : Bond Compiler 0.11.0.0
//   Input filename:  Examples\new.bond
//   Output filename: new_types.cs
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// <auto-generated />
//------------------------------------------------------------------------------


// suppress "Missing XML comment for publicly visible type or member"
#pragma warning disable 1591


#region ReSharper warnings
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable UnusedParameter.Local
// ReSharper disable RedundantUsingDirective
#endregion

namespace Examples
{
    using System.Collections.Generic;

    [global::Bond.Schema]
    [System.CodeDom.Compiler.GeneratedCode("gbc", "0.11.0.0")]
    public partial class Record
    {
        [global::Bond.Id(10), global::Bond.Required]
        public string Name { get; set; }

        [global::Bond.Id(20), global::Bond.Required]
        public string University { get; set; }

        [global::Bond.Id(30), global::Bond.Required]
        public double GraduationY { get; set; }

        public Record()
            : this("Examples.Record", "Record")
        {}

        protected Record(string fullName, string name)
        {
            Name = "";
            University = "";
        }
    }
} // Examples
