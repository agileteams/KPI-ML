///////////////////////////////////////////////////////////
//  KPI_Instance.cs
//  Implementation of the Class KPI_Instance
//  Generated by Enterprise Architect
//  Created on:      22-Oct-2015 10:06:06 PM
//  Original author: dnbrandl
//  Code generator/author: kjsmiley
//  Last revised 2016-08-03
//  The KPI Markup Language (KPI-ML) is used courtesy of MESA International. 
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// MESA KPI Instance class.
/// See http://mesa.org/en/kpiml.asp for more information.
/// </summary>
public class KPI_Instance {

	/// <summary>
	/// List of Audiences for this KPI Instance
	/// </summary>
	public List<string> Audience = new List<string>{};
	/// <summary>
	/// List of texts describing this KPI Instance.
	/// <i>Optional.</i>
	/// </summary>
	public List<string> Description = new List<string>{};
	/// <summary>
	/// List of Effect Model texts describing this KPI Instance
	/// <i>See ISO 22400 standard for list of allowable MIME types.</i>
	/// </summary>
	public List<string> EffectModel = new List<string>{};
	/// <summary>
	/// Text describing the formula used to calculate this KPI Instance
	/// </summary>
	public string Formula = "";
	/// <summary>
	/// Unique identifier for this Instance of the KPI
	/// <i>(if a numeric value is desired, use LONG instead of ULONG </i>
	/// <i>to maximize compatibility across Java and C#. for a string,</i>
	/// <i>consider using string equivalent of a type such as GUID)</i>
	/// </summary>
	public string ID = "";
	/// <summary>
	/// Name of this KPI Instance
	/// </summary>
	public string Name = "";
	/// <summary>
	/// List of Notes for this KPI Instance
	/// </summary>
	public List<string> Notes = new List<string>{};
	/// <summary>
	/// List of texts describing the Production Methodology associated with this KPI
	/// Instance.
	/// Allowable values include:
	///  Batch
	///  Continuous
	///  Discrete
	///  Other (provide other Value)
	/// </summary>
	public List<string> ProductionMethodology = new List<string>{};
	/// <summary>
	/// Lit of texts describing the Scope for this KPI Instance
	/// </summary>
	public List<string> Scope = new List<string>{};
	/// <summary>
	/// List of texts describing the Timing for this KPI Instance
	/// </summary>
	public List<string> Timing = new List<string>{};
	/// <summary>
	/// Desired Trend direction for this KPI Instance
	/// Allowable values include:
	///  higher-is-better
	///  lower-is-better
	///  other (provide other Value)
	/// </summary>
	public string Trend = "";
	/// <summary>
	/// Text describing the Unit of Measure for this KPI Instance
	/// <i>Unconstrained, but SI units are preferred.</i>
    /// Question for MESA XML Committee: how should multiple possible units be handled? e.g. KUSD vs MUSD
	/// </summary>
	public string UnitOfMeasure = "";
	/// <summary>
	/// This KPI Instance Property may apply to another KPI Instance Property
	/// </summary>
	public List<KPI_Instance_Property> m_KPI_Instance_Property = new List<KPI_Instance_Property>();
    /// <summary>
    /// KPI Instance Range
    /// </summary>
	public List<KPI_Range> m_KPI_Range = new List<KPI_Range>();
    /// <summary>
    /// KPI Resource Reference
    /// </summary>
	public List<Resource_Reference> m_Resource_Reference = new List<Resource_Reference>();
    /// <summary>
    /// KPI Instance Time Range
    /// </summary>
	public List<KPI_Instance_Time_Range> m_KPI_Instance_Time_Range = new List<KPI_Instance_Time_Range>();

	/// <summary>
	/// These ID(s) are for KPI Instance(s) used by this KPI Instance for its calculations.
    /// THIS IS DIFFERENT FROM THE XSD which calls for entire definitions, not just IDs.
    /// </summary>
    public List<string> used_in_calculation = new List<string>();
    //public List<KPI_Instance> used_in_calculation;

    /// <summary>
    /// KPI Definition ID on which this Instance ID is based
    /// (note: not auto-generated, need to check schema)
    /// </summary>
    public string KPIDefinitionID;

    /// <summary>
    /// Constructor
    /// </summary>
    public KPI_Instance()
    {

	}

    /// <summary>
    /// Destructor
    /// </summary>
    ~KPI_Instance()
    {

	}

}//end KPI_Instance