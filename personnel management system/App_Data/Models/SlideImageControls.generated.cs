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
	// Mixin content Type 1082 with alias "slideImageControls"
	/// <summary>Slide Image Controls</summary>
	public partial interface ISlideImageControls : IPublishedContent
	{
		/// <summary>Slide Image</summary>
		IPublishedContent SlideImage { get; }
	}

	/// <summary>Slide Image Controls</summary>
	[PublishedContentModel("slideImageControls")]
	public partial class SlideImageControls : PublishedContentModel, ISlideImageControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slideImageControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public SlideImageControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<SlideImageControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Slide Image: Add an image for the slide
		///</summary>
		[ImplementPropertyType("slideImage")]
		public IPublishedContent SlideImage
		{
			get { return GetSlideImage(this); }
		}

		/// <summary>Static getter for Slide Image</summary>
		public static IPublishedContent GetSlideImage(ISlideImageControls that) { return that.GetPropertyValue<IPublishedContent>("slideImage"); }
	}
}
