using NHapi.Base.Parser;
using NHapi.Base;
using NHapi.Base.Log;
using System;
using System.Collections.Generic;
using NHapi.Model.V281.Segment;
using NHapi.Model.V281.Datatype;
using NHapi.Base.Model;

namespace NHapi.Model.V281.Group
{
///<summary>
///Represents the RDR_RDR_DEFINITION Group.  A Group is an ordered collection of message 
/// segments that can repeat together or be optionally in/excluded together.
/// This Group contains the following elements: 
///<ol>
///<li>0: QRD (deprecated) </li>
///<li>1: QRF (deprecated) optional </li>
///<li>2: RDR_RDR_PATIENT (a Group object) optional </li>
///<li>3: RDR_RDR_ORDER (a Group object) repeating</li>
///</ol>
///</summary>
[Serializable]
public class RDR_RDR_DEFINITION : AbstractGroup {

	///<summary> 
	/// Creates a new RDR_RDR_DEFINITION Group.
	///</summary>
	public RDR_RDR_DEFINITION(IGroup parent, IModelClassFactory factory) : base(parent, factory){
	   try {
	      this.add(typeof(QRD), true, false);
	      this.add(typeof(QRF), false, false);
	      this.add(typeof(RDR_RDR_PATIENT), false, false);
	      this.add(typeof(RDR_RDR_ORDER), true, true);
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating RDR_RDR_DEFINITION - this is probably a bug in the source code generator.", e);
	   }
	}

	///<summary>
	/// Returns QRD (deprecated) - creates it if necessary
	///</summary>
	public QRD QRD { 
get{
	   QRD ret = null;
	   try {
	      ret = (QRD)this.GetStructure("QRD");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns QRF (deprecated) - creates it if necessary
	///</summary>
	public QRF QRF { 
get{
	   QRF ret = null;
	   try {
	      ret = (QRF)this.GetStructure("QRF");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns RDR_RDR_PATIENT (a Group object) - creates it if necessary
	///</summary>
	public RDR_RDR_PATIENT PATIENT { 
get{
	   RDR_RDR_PATIENT ret = null;
	   try {
	      ret = (RDR_RDR_PATIENT)this.GetStructure("PATIENT");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}
	}

	///<summary>
	/// Returns  first repetition of RDR_RDR_ORDER (a Group object) - creates it if necessary
	///</summary>
	public RDR_RDR_ORDER GetORDER() {
	   RDR_RDR_ORDER ret = null;
	   try {
	      ret = (RDR_RDR_ORDER)this.GetStructure("ORDER");
	   } catch(HL7Exception e) {
	      HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
	      throw new System.Exception("An unexpected error ocurred",e);
	   }
	   return ret;
	}

	///<summary>
	///Returns a specific repetition of RDR_RDR_ORDER
	/// * (a Group object) - creates it if necessary
	/// throws HL7Exception if the repetition requested is more than one 
	///     greater than the number of existing repetitions.
	///</summary>
	public RDR_RDR_ORDER GetORDER(int rep) { 
	   return (RDR_RDR_ORDER)this.GetStructure("ORDER", rep);
	}

	/** 
	 * Returns the number of existing repetitions of RDR_RDR_ORDER 
	 */ 
	public int ORDERRepetitionsUsed { 
get{
	    int reps = -1; 
	    try { 
	        reps = this.GetAll("ORDER").Length; 
	    } catch (HL7Exception e) { 
	        string message = "Unexpected error accessing data - this is probably a bug in the source code generator."; 
	        HapiLogFactory.GetHapiLog(GetType()).Error(message, e); 
	        throw new System.Exception(message);
	    } 
	    return reps; 
	}
	} 

	/** 
	 * Enumerate over the RDR_RDR_ORDER results 
	 */ 
	public IEnumerable<RDR_RDR_ORDER> ORDERs 
	{ 
		get
		{
			for (int rep = 0; rep < ORDERRepetitionsUsed; rep++)
			{
				yield return (RDR_RDR_ORDER)this.GetStructure("ORDER", rep);
			}
		}
	}

	///<summary>
	///Adds a new RDR_RDR_ORDER
	///</summary>
	public RDR_RDR_ORDER AddORDER()
	{
		return this.AddStructure("ORDER") as RDR_RDR_ORDER;
	}

	///<summary>
	///Removes the given RDR_RDR_ORDER
	///</summary>
	public void RemoveORDER(RDR_RDR_ORDER toRemove)
	{
		this.RemoveStructure("ORDER", toRemove);
	}

	///<summary>
	///Removes the RDR_RDR_ORDER at the given index
	///</summary>
	public void RemoveORDERAt(int index)
	{
		this.RemoveRepetition("ORDER", index);
	}

}
}
