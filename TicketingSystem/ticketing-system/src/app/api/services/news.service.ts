/* tslint:disable */
/* eslint-disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse, HttpContext } from '@angular/common/http';
import { BaseService } from '../base-service';
import { ApiConfiguration } from '../api-configuration';
import { StrictHttpResponse } from '../strict-http-response';
import { RequestBuilder } from '../request-builder';
import { Observable } from 'rxjs';
import { map, filter } from 'rxjs/operators';

import { CreateNews } from '../models/create-news';
import { NewsDetails } from '../models/news-details';
import { NewsHeader } from '../models/news-header';

@Injectable({
  providedIn: 'root',
})
export class NewsService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiNewsGet
   */
  static readonly ApiNewsGetPath = '/api/News';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiNewsGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsGet$Plain$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<NewsHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, NewsService.ApiNewsGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<NewsHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiNewsGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsGet$Plain(params?: {
  },
  context?: HttpContext

): Observable<Array<NewsHeader>> {

    return this.apiNewsGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<NewsHeader>>) => r.body as Array<NewsHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiNewsGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsGet$Json$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<NewsHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, NewsService.ApiNewsGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<NewsHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiNewsGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsGet$Json(params?: {
  },
  context?: HttpContext

): Observable<Array<NewsHeader>> {

    return this.apiNewsGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<NewsHeader>>) => r.body as Array<NewsHeader>)
    );
  }

  /**
   * Path part for operation apiNewsPost
   */
  static readonly ApiNewsPostPath = '/api/News';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiNewsPost()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiNewsPost$Response(params?: {
    body?: CreateNews
  },
  context?: HttpContext

): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, NewsService.ApiNewsPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: '*/*',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return (r as HttpResponse<any>).clone({ body: undefined }) as StrictHttpResponse<void>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiNewsPost$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiNewsPost(params?: {
    body?: CreateNews
  },
  context?: HttpContext

): Observable<void> {

    return this.apiNewsPost$Response(params,context).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

  /**
   * Path part for operation apiNewsNewsUrlIdGet
   */
  static readonly ApiNewsNewsUrlIdGetPath = '/api/News/{newsUrlId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiNewsNewsUrlIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsNewsUrlIdGet$Plain$Response(params: {
    newsUrlId: string;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<NewsDetails>> {

    const rb = new RequestBuilder(this.rootUrl, NewsService.ApiNewsNewsUrlIdGetPath, 'get');
    if (params) {
      rb.path('newsUrlId', params.newsUrlId, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<NewsDetails>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiNewsNewsUrlIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsNewsUrlIdGet$Plain(params: {
    newsUrlId: string;
  },
  context?: HttpContext

): Observable<NewsDetails> {

    return this.apiNewsNewsUrlIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<NewsDetails>) => r.body as NewsDetails)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiNewsNewsUrlIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsNewsUrlIdGet$Json$Response(params: {
    newsUrlId: string;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<NewsDetails>> {

    const rb = new RequestBuilder(this.rootUrl, NewsService.ApiNewsNewsUrlIdGetPath, 'get');
    if (params) {
      rb.path('newsUrlId', params.newsUrlId, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<NewsDetails>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiNewsNewsUrlIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiNewsNewsUrlIdGet$Json(params: {
    newsUrlId: string;
  },
  context?: HttpContext

): Observable<NewsDetails> {

    return this.apiNewsNewsUrlIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<NewsDetails>) => r.body as NewsDetails)
    );
  }

}
