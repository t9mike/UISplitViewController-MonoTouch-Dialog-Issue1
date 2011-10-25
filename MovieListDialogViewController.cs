using System;
using System.Linq;
using Com.Muegel.MonoTouch;
using MonoTouch.UIKit;
using MonoTouch.Dialog;
using Com.Muegel.AintItCool;
using System.Drawing;
using MonoTouch.CoreGraphics;
using TIDP.Logging;
using TIDP;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace TabPlusNav1
{
	public class MovieListDialogViewController : ArticleTaskDialogViewController<Movie>
	{	
		// EVENTS I FIRE ///////////////////////////////////////////////
		
		// PUBLIC INNER TYPES //////////////////////////////////////////
		
		// PRIVATE INNER TYPES /////////////////////////////////////////
		
		// PUBLIC FIELDS, PROPERTIES, AND CONSTANTS ////////////////////
		
		// PRIVATE FIELDS, PROPERTIES, AND CONSTANTS ///////////////////
		private Article Article;
		
		protected override IEnumerable<Movie> Rows 
		{
			get { return Article.Movies; }
		}
		
		protected override Movie Row_To_Select 
		{
			get { return My.App.Auto_Navigate_Movie; }
		}
		
		// CONSTRUCTORS ////////////////////////////////////////////////
		public MovieListDialogViewController(Article article) : base(UITableViewStyle.Plain, true)
		{
			Article = article;
			Show_Toolbar = true;
			Create_Toolbar();
						
			Root = new RootElement(article.Date_Published_String, new RadioGroup(0))
			{
				new Section()
				{
					from movie in article.Movies
						select(Element)new MovieListElement(this, movie, false)
				}
			};			
		}
		
		// PUBLIC METHODS //////////////////////////////////////////////
		
		// EVENTS I HANDLE /////////////////////////////////////////////
		
		// PRIVATE METHODS /////////////////////////////////////////////
		protected override void Selected(int row_i, Movie movie)
		{
			My.App.Movie_View.Show(movie);
			My.App.Settings.Last_Articles_Task_Movie_ASIN = movie.AISN;
		}		
	}
}