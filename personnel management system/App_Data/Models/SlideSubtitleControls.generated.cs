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
	// Mixin content Type 1084 with alias "slideSubtitleControls"
	/// <summary>Slide Subtitle Controls</summary>
	public partial interface ISlideSubtitleControls : IPublishedContent
	{
		/// <summary>Slide Subtitle</summary>
		string SlideSubtitle { get; }
	}

	/// <summary>Slide Subtitle Controls</summary>
	[PublishedContentModel("slideSubtitleControls")]
	public partial class SlideSubtitleControls : PublishedContentModel, ISlideSubtitleControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slideSubtitleControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SlideSubtitleControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideSubtitleControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Slide Subtitle: Enter the subtitle for this slide
		///</summary>
		[ImplementPropertyType("slideSubtitle")]
		public string SlideSubtitle
		{
			get { return GetSlideSubtitle(this); }
		}

		/// <summary>Static getter for Slide Subtitle</summary>
		public static string GetSlideSubtitle(ISlideSubtitleControls that) { return that.GetPropertyValue<string>("slideSubtitle"); }
	}
}
