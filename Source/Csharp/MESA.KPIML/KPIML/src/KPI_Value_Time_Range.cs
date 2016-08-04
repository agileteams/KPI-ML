///////////////////////////////////////////////////////////
//  KPI_Value_Time_Range.cs
//  Implementation of the Class KPI_Value_Time_Range
//  Generated by Enterprise Architect
//  Created on:      22-Oct-2015 10:06:06 PM
//  Original author: dnbrandl
//  Code generator/author: kjsmiley
//  Last revised 2016-07-15
//  The KPI Markup Language (KPI-ML) is used courtesy of MESA International. 
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



/// <summary>
/// MESA KPI Value Time Range class.
/// See http://mesa.org/en/kpiml.asp for more information.
/// </summary>
public class KPI_Value_Time_Range : MESA.KPIML.KPI_Time_Range
{
#if SUPERSEDED
	/// <summary>
	/// Duration of this Time Range for the KPI Value.
	/// <i>See standard for syntax.</i>
	/// </summary>
	public string Duration = "";
	/// <summary>
	/// End point of this Time Range for the KPI Value
	/// </summary>
	public DateTime EndTime = DateTime.MaxValue;
	/// <summary>
	/// Recurrence of this Time Range for the KPI Value
	/// </summary>
	public string Recurrence = "";
	/// <summary>
	/// Start point of this Time Range for the KPI Value
	/// </summary>
	public DateTime StartTime = DateTime.MinValue;

    /// <summary>
    /// Constructor
    /// </summary>
    public KPI_Value_Time_Range()
    {

	}

    /// <summary>
    /// Destructor
    /// </summary>
    ~KPI_Value_Time_Range()
    {

	}
#endif
}//end KPI_Value_Time_Range