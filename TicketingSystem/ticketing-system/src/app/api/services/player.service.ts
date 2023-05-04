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

import { PlayerHeader } from '../models/player-header';

@Injectable({
  providedIn: 'root',
})
export class PlayerService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiPlayerTeamGet
   */
  static readonly ApiPlayerTeamGetPath = '/api/Player/team';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerTeamGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerTeamGet$Plain$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<PlayerHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerTeamGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<PlayerHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerTeamGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerTeamGet$Plain(params?: {
  },
  context?: HttpContext

): Observable<Array<PlayerHeader>> {

    return this.apiPlayerTeamGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<PlayerHeader>>) => r.body as Array<PlayerHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerTeamGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerTeamGet$Json$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<PlayerHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerTeamGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<PlayerHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerTeamGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerTeamGet$Json(params?: {
  },
  context?: HttpContext

): Observable<Array<PlayerHeader>> {

    return this.apiPlayerTeamGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<PlayerHeader>>) => r.body as Array<PlayerHeader>)
    );
  }

  /**
   * Path part for operation apiPlayerPlayerIdGet
   */
  static readonly ApiPlayerPlayerIdGetPath = '/api/Player/{playerId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerPlayerIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdGet$Plain$Response(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<PlayerHeader>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerPlayerIdGetPath, 'get');
    if (params) {
      rb.path('playerId', params.playerId, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlayerHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerPlayerIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdGet$Plain(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<PlayerHeader> {

    return this.apiPlayerPlayerIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<PlayerHeader>) => r.body as PlayerHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerPlayerIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdGet$Json$Response(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<PlayerHeader>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerPlayerIdGetPath, 'get');
    if (params) {
      rb.path('playerId', params.playerId, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlayerHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerPlayerIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdGet$Json(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<PlayerHeader> {

    return this.apiPlayerPlayerIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<PlayerHeader>) => r.body as PlayerHeader)
    );
  }

  /**
   * Path part for operation apiPlayerPlayerIdDelete
   */
  static readonly ApiPlayerPlayerIdDeletePath = '/api/Player/{playerId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerPlayerIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdDelete$Response(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerPlayerIdDeletePath, 'delete');
    if (params) {
      rb.path('playerId', params.playerId, {});
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
   * To access the full response (for headers, for example), `apiPlayerPlayerIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiPlayerPlayerIdDelete(params: {
    playerId: number;
  },
  context?: HttpContext

): Observable<void> {

    return this.apiPlayerPlayerIdDelete$Response(params,context).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

  /**
   * Path part for operation apiPlayerPost
   */
  static readonly ApiPlayerPostPath = '/api/Player';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlayerPost$Plain$Response(params?: {
    body?: PlayerHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<PlayerHeader>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlayerHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlayerPost$Plain(params?: {
    body?: PlayerHeader
  },
  context?: HttpContext

): Observable<PlayerHeader> {

    return this.apiPlayerPost$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<PlayerHeader>) => r.body as PlayerHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiPlayerPost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlayerPost$Json$Response(params?: {
    body?: PlayerHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<PlayerHeader>> {

    const rb = new RequestBuilder(this.rootUrl, PlayerService.ApiPlayerPostPath, 'post');
    if (params) {
      rb.body(params.body, 'application/*+json');
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<PlayerHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiPlayerPost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiPlayerPost$Json(params?: {
    body?: PlayerHeader
  },
  context?: HttpContext

): Observable<PlayerHeader> {

    return this.apiPlayerPost$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<PlayerHeader>) => r.body as PlayerHeader)
    );
  }

}
