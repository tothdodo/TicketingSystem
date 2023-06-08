import { Component } from '@angular/core';
import { NewsHeader } from 'src/app/api/models';
import { NewsService } from 'src/app/api/services';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  /**
   * Collection of all the news
   */
  newsCollection: NewsHeader[] = [];

  /**
   * Collection of news to be shown on the current page
   */
  shownNewsCollection: NewsHeader[] = [];

  /**
   * Pagination variables
   */
  currentPage: number = 1;
  itemsPerPage: number = 5;
  totalPages: number = 0;

  /**
   * @param newsService DI for the news service
   */
  constructor(private newsService: NewsService) { }

  /**
   * Gets all the news and sorts them by date descending
   */
  ngOnInit(): void {
    this.newsService.apiNewsGet$Json$Response().subscribe(
      (response) => {
        this.newsCollection = response.body || [];
      },
      (err) => {
        console.error(err);
      }
    );
    this.newsCollection.sort((a, b) => {
      if (a.publishDate && b.publishDate) {
        return b.publishDate.toString().localeCompare(a.publishDate.toString());
      }
      return 0;
    });
    this.totalPages = Math.ceil(this.newsCollection.length / this.itemsPerPage);
    this.getItemsForCurrentPage();
  }

  /**
   * Gets the news for the current page
   */
  getItemsForCurrentPage() {
    const startIndex = (this.currentPage - 1) * this.itemsPerPage;
    const endIndex = startIndex + this.itemsPerPage;
    this.shownNewsCollection = this.newsCollection.slice(startIndex, endIndex);
  }

  /**
   * Sets the current page to the previous one
   */
  previousPage() {
    if (this.currentPage > 1) {
      this.currentPage--;
    }
  }

  /**
   * Sets the current page to the next one
   */
  nextPage() {
    if (this.currentPage < this.totalPages) {
      this.currentPage++;
    }
  }

  /**
   * @param news News to get the image source for
   * @returns string of the image source
   */
  getImageSource(news: NewsHeader) {
    return "assets/images/news/" + news.image;
  }

  /**
   * Sets the news's date to the format: Month Day
   * @param news News to get the month and day for
   * @returns String with the month and day
   */
  getMonthAndDay(news: NewsHeader) {
    const date = new Date();
    date.setMonth(Number(news.publishDate?.toString().split("-")[1]) - 1);

    return date.toLocaleString('en-US', { month: 'long' }) + " " + news.publishDate?.toString().split("-")[2].split("T")[0];
  }

  /**
   * @param news News to get the day of the week for
   * @returns Day of the week
   */
  getDayOfTheWeek(news: NewsHeader) {
    const date = new Date(
      news.publishDate?.toString()!,
    );
    const daysOfWeek: string[] = ['Sunday', 'Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday', 'Saturday'];
    const dayIndex: number = date.getDay();
    return daysOfWeek[dayIndex];    
  }
}
