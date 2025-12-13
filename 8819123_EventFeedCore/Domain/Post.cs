using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFeedCore.Domain
{
	public class Post
	{
		public int Id { get; }
		public string Author { get; }
		public string Content { get; }
		public int Likes { get; private set; }
		public bool IsPinned { get; set; }

		public Post(int id, string author, string content)
		{
			Id = id;
			Author = author;
			Content = content;
			Likes = 0;
			IsPinned = false;
		}

		public void AddLike() => Likes++;
	}
}
