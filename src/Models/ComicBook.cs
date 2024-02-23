namespace ComicBookGallery.Models
{
	public class ComicBook
	{
		public int Id { get; set; }
		public required string SeriesTitle { get; set; }
		public int IssueNumber { get; set; }
		public required string DescriptionHtml { get; set; }
		public required Artist[] Artists { get; set; }
		public bool Favourite { get; set; }

		public string DisplayText
		{
			get
			{
				return SeriesTitle + " #" + IssueNumber;
			}
		}

		public string CoverImageFileName
		{
			get
			{
				return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg";
			}
		}
	}
}