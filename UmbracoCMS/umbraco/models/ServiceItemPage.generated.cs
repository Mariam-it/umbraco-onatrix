//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.3.0+32c00f9
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Service Item Page</summary>
	[PublishedModel("serviceItemPage")]
	public partial class ServiceItemPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		public new const string ModelTypeAlias = "serviceItemPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ServiceItemPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ServiceItemPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// Service Item Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceItemImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceItemImage");

		///<summary>
		/// Service Item Image2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemImage2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceItemImage2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceItemImage2");

		///<summary>
		/// Service Item SubTitle1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemSubTitle1")]
		public virtual string ServiceItemSubTitle1 => this.Value<string>(_publishedValueFallback, "serviceItemSubTitle1");

		///<summary>
		/// Service Item SubTitle2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemSubTitle2")]
		public virtual string ServiceItemSubTitle2 => this.Value<string>(_publishedValueFallback, "serviceItemSubTitle2");

		///<summary>
		/// Service Item SubTitle3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemSubTitle3")]
		public virtual string ServiceItemSubTitle3 => this.Value<string>(_publishedValueFallback, "serviceItemSubTitle3");

		///<summary>
		/// Service Item Text1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText1")]
		public virtual string ServiceItemText1 => this.Value<string>(_publishedValueFallback, "serviceItemText1");

		///<summary>
		/// Service Item Text10
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText10")]
		public virtual string ServiceItemText10 => this.Value<string>(_publishedValueFallback, "serviceItemText10");

		///<summary>
		/// Service Item Text11
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText11")]
		public virtual string ServiceItemText11 => this.Value<string>(_publishedValueFallback, "serviceItemText11");

		///<summary>
		/// Service Item Text12
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText12")]
		public virtual string ServiceItemText12 => this.Value<string>(_publishedValueFallback, "serviceItemText12");

		///<summary>
		/// Service Item Text13
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText13")]
		public virtual string ServiceItemText13 => this.Value<string>(_publishedValueFallback, "serviceItemText13");

		///<summary>
		/// Service Item Text14
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText14")]
		public virtual string ServiceItemText14 => this.Value<string>(_publishedValueFallback, "serviceItemText14");

		///<summary>
		/// Service Item Text15
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText15")]
		public virtual string ServiceItemText15 => this.Value<string>(_publishedValueFallback, "serviceItemText15");

		///<summary>
		/// Service Item Text16
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText16")]
		public virtual string ServiceItemText16 => this.Value<string>(_publishedValueFallback, "serviceItemText16");

		///<summary>
		/// Service Item Text2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText2")]
		public virtual string ServiceItemText2 => this.Value<string>(_publishedValueFallback, "serviceItemText2");

		///<summary>
		/// Service Item Text3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText3")]
		public virtual string ServiceItemText3 => this.Value<string>(_publishedValueFallback, "serviceItemText3");

		///<summary>
		/// Service Item Text4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText4")]
		public virtual string ServiceItemText4 => this.Value<string>(_publishedValueFallback, "serviceItemText4");

		///<summary>
		/// Service Item Text5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText5")]
		public virtual string ServiceItemText5 => this.Value<string>(_publishedValueFallback, "serviceItemText5");

		///<summary>
		/// Service Item Text6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText6")]
		public virtual string ServiceItemText6 => this.Value<string>(_publishedValueFallback, "serviceItemText6");

		///<summary>
		/// Service Item Text7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText7")]
		public virtual string ServiceItemText7 => this.Value<string>(_publishedValueFallback, "serviceItemText7");

		///<summary>
		/// Service Item Text8
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText8")]
		public virtual string ServiceItemText8 => this.Value<string>(_publishedValueFallback, "serviceItemText8");

		///<summary>
		/// Service Item Text9
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.3.0+32c00f9")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceItemText9")]
		public virtual string ServiceItemText9 => this.Value<string>(_publishedValueFallback, "serviceItemText9");
	}
}
