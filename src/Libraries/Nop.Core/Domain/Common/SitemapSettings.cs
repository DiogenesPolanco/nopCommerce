using System.Collections.Generic;
using Nop.Core.Configuration;

namespace Nop.Core.Domain.Common
{
    /// <summary>
    /// Sitemap settings
    /// </summary>
    public class SitemapSettings : ISettings
    {
        public SitemapSettings()
        {
            SitemapCustomUrls = new List<string>();
        }

        /// <summary>
        /// Gets or sets a value indicating whether sitemap is enabled
        /// </summary>
        public bool SitemapEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether sitemap.xml is enabled
        /// </summary>
        public bool SitemapXmlEnabled { get; set; }

        /// <summary>
        /// Gets or sets the page size for sitemap
        /// </summary>
        public int SitemapPageSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include blog posts to sitemap
        /// </summary>
        public bool SitemapIncludeBlogPosts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include blog posts to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeBlogPosts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include categories to sitemap
        /// </summary>
        public bool SitemapIncludeCategories { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include categories to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeCategories { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include custom urls to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeCustomUrls { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include manufacturers to sitemap
        /// </summary>
        public bool SitemapIncludeManufacturers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include manufacturers to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeManufacturers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include news to sitemap
        /// </summary>
        public bool SitemapIncludeNews { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include news to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeNews { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include products to sitemap
        /// </summary>
        public bool SitemapIncludeProducts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include products to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeProducts { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include product tags to sitemap
        /// </summary>
        public bool SitemapIncludeProductTags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include product tags to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeProductTags { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include topics to sitemap
        /// </summary>
        public bool SitemapIncludeTopics { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to include topics to sitemap.xml
        /// </summary>
        public bool SitemapXmlIncludeTopics { get; set; }

        /// <summary>
        /// A list of custom URLs to be added to sitemap.xml (include page names only)
        /// </summary>
        public List<string> SitemapCustomUrls { get; set; }
    }
}
