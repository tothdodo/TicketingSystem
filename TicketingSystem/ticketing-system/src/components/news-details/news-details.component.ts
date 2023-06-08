import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { NewsDetails } from 'src/app/api/models';
import { NewsService } from 'src/app/api/services';
import { StrictHttpResponse } from 'src/app/api/strict-http-response';

@Component({
  selector: 'app-news-details',
  templateUrl: './news-details.component.html',
  styleUrls: ['./news-details.component.css']
})
export class NewsDetailsComponent {
  /**
   * News url id from the route
   * Used to get the news details
   */
  newsUrlId?: string;

  /**
   * News details to be displayed
   */
  news? : NewsDetails;

  /**
   * @param newsService DI for the news service
   * @param route DI for the activated route
   */
  constructor(private newsService: NewsService, private route: ActivatedRoute) {}
  
  /**
   * Gets the news url id from the route
   * Gets the news details from the database
   */
  ngOnInit(): void {
    this.newsUrlId = String(this.route.snapshot.paramMap.get('newsUrlId'));
    this.newsService.apiNewsNewsUrlIdGet$Json$Response({newsUrlId: this.newsUrlId}).subscribe(
      (news: StrictHttpResponse<NewsDetails>) => {
        this.news = news.body;
    },
    error => {
      console.log(error);
    }
    );
  }

  /**
   * @param news News to get the image source for
   * @returns Img source
   */
  getImageSource(news: NewsDetails) {
    return "assets/images/news/" + news.image;
  }

  /**
   * @param date Date to be formatted
   * @returns Formatted date
   */
  formatDate(date: Date) {
    const dateTime = new Date(date);
    const year = dateTime.getFullYear();
    const month = String(dateTime.getMonth() + 1).padStart(2, '0');
    const newDate = String(dateTime.getDate()).padStart(2, '0');
    const hour = String(dateTime.getHours()).padStart(2, '0');
    const minute = String(dateTime.getMinutes()).padStart(2, '0');
    return `${year} ${this.getMonthName(Number(month)).slice(0, 3)} ${newDate} ${hour}:${minute}`.toUpperCase();
  }

  /**
   * @param monthNumber Month number to get the name for
   * @returns Month name
   */
  getMonthName(monthNumber: number) {
    const date = new Date();
    date.setMonth(monthNumber - 1);
  
    return date.toLocaleString('en-US', { month: 'long' });
  }
}
