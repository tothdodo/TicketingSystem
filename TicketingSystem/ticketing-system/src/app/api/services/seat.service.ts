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

import { SeatHeader } from '../models/seat-header';

@Injectable({
  providedIn: 'root',
})
export class SeatService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiSeatSeatsGet
   */
  static readonly ApiSeatSeatsGetPath = '/api/Seat/seats';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSeatSeatsGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSeatSeatsGet$Plain$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SeatHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SeatService.ApiSeatSeatsGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<SeatHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSeatSeatsGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSeatSeatsGet$Plain(params?: {
  },
  context?: HttpContext

): Observable<Array<SeatHeader>> {

    return this.apiSeatSeatsGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SeatHeader>>) => r.body as Array<SeatHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSeatSeatsGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSeatSeatsGet$Json$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SeatHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SeatService.ApiSeatSeatsGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<SeatHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSeatSeatsGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSeatSeatsGet$Json(params?: {
  },
  context?: HttpContext

): Observable<Array<SeatHeader>> {

    return this.apiSeatSeatsGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SeatHeader>>) => r.body as Array<SeatHeader>)
    );
  }

  /**
   * Path part for operation apiSeatGameIdPut
   */
  static readonly ApiSeatGameIdPutPath = '/api/Seat/{gameId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSeatGameIdPut$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiSeatGameIdPut$Plain$Response(params: {
    gameId: number;
    body?: SeatHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<SeatHeader>> {

    const rb = new RequestBuilder(this.rootUrl, SeatService.ApiSeatGameIdPutPath, 'put');
    if (params) {
      rb.path('gameId', params.gameId, {});
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<SeatHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSeatGameIdPut$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiSeatGameIdPut$Plain(params: {
    gameId: number;
    body?: SeatHeader
  },
  context?: HttpContext

): Observable<SeatHeader> {

    return this.apiSeatGameIdPut$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<SeatHeader>) => r.body as SeatHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSeatGameIdPut$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiSeatGameIdPut$Json$Response(params: {
    gameId: number;
    body?: SeatHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<SeatHeader>> {

    const rb = new RequestBuilder(this.rootUrl, SeatService.ApiSeatGameIdPutPath, 'put');
    if (params) {
      rb.path('gameId', params.gameId, {});
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<SeatHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSeatGameIdPut$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiSeatGameIdPut$Json(params: {
    gameId: number;
    body?: SeatHeader
  },
  context?: HttpContext

): Observable<SeatHeader> {

    return this.apiSeatGameIdPut$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<SeatHeader>) => r.body as SeatHeader)
    );
  }

}
