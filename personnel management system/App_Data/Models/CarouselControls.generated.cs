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
	// Mixin content Type 1073 with alias "carouselControls"
	/// <summary>Carousel Controls</summary>
	public partial interface ICarouselControls : IPublishedContent
	{
		/// <summary>Main Carousel</summary>
		IEnumerable<IPublishedContent> MainCarousel { get; }
	}

	/// <summary>Carousel Controls</summary>
	[PublishedContentModel("carouselControls")]
	public partial class CarouselControls : PublishedContentModel, ICarouselControls
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "carouselControls";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CarouselControls(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CarouselControls, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Main Carousel: Add the items for the carousel
		///</summary>
		[ImplementPropertyType("mainCarousel")]
		public IEnumerable<IPublishedContent> MainCarousel
		{
			get { return GetMainCarousel(this); }
		}

		/// <summary>Static getter for Main Carousel</summary>
		public static IEnumerable<IPublishedContent> GetMainCarousel(ICarouselControls that) { return that.GetPropertyValue<IEnumerable<IPublishedContent>>("mainCarousel"); }
	}
}
