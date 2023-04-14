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

import { GameHeader } from '../models/game-header';

@Injectable({
  providedIn: 'root',
})
export class GameService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiGameGamesGet
   */
  static readonly ApiGameGamesGetPath = '/api/Game/games';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGamesGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGet$Plain$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<GameHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGamesGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<GameHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGamesGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGet$Plain(params?: {
  },
  context?: HttpContext

): Observable<Array<GameHeader>> {

    return this.apiGameGamesGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<GameHeader>>) => r.body as Array<GameHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGamesGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGet$Json$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<GameHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGamesGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<GameHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGamesGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGet$Json(params?: {
  },
  context?: HttpContext

): Observable<Array<GameHeader>> {

    return this.apiGameGamesGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<GameHeader>>) => r.body as Array<GameHeader>)
    );
  }

}
