//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	// Mixin content Type 1080 with alias "prettyLinkControls"
	/// <summary>Pretty Link Controls</summary>
	public partial interface IPrettyLinkControls : IPublishedContent
	{
		/// <summary>Link Target</summary>
		Umbraco.Web.Models.RelatedLinks LinkTarget { get; }
	}

	/// <summary>Pretty Link Controls</summary>
	[PublishedContentModel("prettyLinkControls")]
	public partial class PrettyLinkControls : PublishedContentModel, IPrettyLinkControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "prettyLinkControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public PrettyLinkControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PrettyLinkControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Link Target: Enter the link for this pretty link to point to
		///</summary>
		[ImplementPropertyType("linkTarget")]
		public Umbraco.Web.Models.RelatedLinks LinkTarget
		{
			get { return GetLinkTarget(this); }
		}

		/// <summary>Static getter for Link Target</summary>
		public static Umbraco.Web.Models.RelatedLinks GetLinkTarget(IPrettyLinkControls that) { return that.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("linkTarget"); }
	}
}
