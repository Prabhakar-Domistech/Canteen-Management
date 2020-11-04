﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
  public  class ML_CokeDynamicResult
    {
        #region Properties
        /// <summary>
        /// Gets or sets the Id value.
        /// </summary>
        public Int64 Id { get; set; }
        /// <summary>
        /// Gets or sets the CokeDynamicResultId value.
        /// </summary>
        public Int64 CokeDynamicResultId { get; set; }
        /// <summary>
        /// Gets or sets the CokeDynamicResult value.
        /// </summary>
        public String CokeDynamicResult { get; set; }
        /// <summary>
        /// Gets or sets the CokeDynamicId value.
        /// </summary>
        public Int32 CokeDynamicId { get; set; }
        /// <summary>
        /// Gets or sets the CokeDynamic value.
        /// </summary>
        public String CokeDynamic { get; set; }
        /// <summary>
        /// Gets or sets the CPCokeId value.
        /// </summary>
        public Int32 CokeCompositeMasterId { get; set; }
        /// <summary>
        /// Gets or sets the CPCokeName value.
        /// </summary>
        public String CokeCompositeMaster { get; set; }
        /// <summary>
        /// Gets or sets the CokeTypeId value.
        /// </summary>
        public Int32 CokeTypeId { get; set; }
        /// <summary>
        /// Gets or sets the CokeType value.
        /// </summary>
        public String CokeType { get; set; }
        /// <summary>
        /// Gets or sets the CokeSupplierId value.
        /// </summary>
        public Int32 CokeSupplierId { get; set; }
        /// <summary>
        /// Gets or sets the CokeSupplier value.
        /// </summary>
        public String CokeSupplier { get; set; }
        /// <summary>
        /// Gets or sets the AnalysisTypeId value.
        /// </summary>
        public Int32 AnalysisTypeId { get; set; }
        /// <summary>
        /// Gets or sets the AnalysisType value.
        /// </summary>
        public String AnalysisType { get; set; }
        /// <summary>
        /// Gets or sets the FieldSize value.
        /// </summary>
        public String FieldSize { get; set; }
        /// <summary>
        /// Gets or sets the FieldUnit value.
        /// </summary>
        public String FieldUnit { get; set; }
        /// <summary>
        /// Gets or sets the FieldSpec value.
        /// </summary>
        public String FieldSpec { get; set; }
        /// <summary>
        /// Gets or sets the MinValue value.
        /// </summary>
        public Nullable<Double> Result { get; set; }
        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public String MinValue { get; set; }
        /// <summary>
        /// Gets or sets the MaxValue value.
        /// </summary>
        public String MaxValue { get; set; }
        /// <summary>
        /// Gets or sets the FromDate value.
        /// </summary>
        public DateTime? FromDate { get; set; }
        /// <summary>
        /// Gets or sets the ToDate value.
        /// </summary>
        public DateTime? ToDate { get; set; }
        #endregion
    }
}