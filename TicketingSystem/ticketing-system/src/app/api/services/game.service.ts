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

import { CreateGame } from '../models/create-game';
import { GameDetails } from '../models/game-details';
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

  /**
   * Path part for operation apiGameGameIdGet
   */
  static readonly ApiGameGameIdGetPath = '/api/Game/{gameId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGameIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdGet$Plain$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameHeader>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGameIdGetPath, 'get');
    if (params) {
      rb.path('gameId', params.gameId, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<GameHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGameIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdGet$Plain(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<GameHeader> {

    return this.apiGameGameIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameHeader>) => r.body as GameHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGameIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdGet$Json$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameHeader>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGameIdGetPath, 'get');
    if (params) {
      rb.path('gameId', params.gameId, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<GameHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGameIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdGet$Json(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<GameHeader> {

    return this.apiGameGameIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameHeader>) => r.body as GameHeader)
    );
  }

  /**
   * Path part for operation apiGameGameIdDelete
   */
  static readonly ApiGameGameIdDeletePath = '/api/Game/{gameId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGameIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdDelete$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGameIdDeletePath, 'delete');
    if (params) {
      rb.path('gameId', params.gameId, {});
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
   * To access the full response (for headers, for example), `apiGameGameIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGameIdDelete(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<void> {

    return this.apiGameGameIdDelete$Response(params,context).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

  /**
   * Path part for operation apiGameGamesGameIdGet
   */
  static readonly ApiGameGamesGameIdGetPath = '/api/Game/games/{gameId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGamesGameIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGameIdGet$Plain$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameDetails>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGamesGameIdGetPath, 'get');
    if (params) {
      rb.path('gameId', params.gameId, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<GameDetails>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGamesGameIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGameIdGet$Plain(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<GameDetails> {

    return this.apiGameGamesGameIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameDetails>) => r.body as GameDetails)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGameGamesGameIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGameIdGet$Json$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameDetails>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGameGamesGameIdGetPath, 'get');
    if (params) {
      rb.path('gameId', params.gameId, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<GameDetails>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGameGamesGameIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiGameGamesGameIdGet$Json(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<GameDetails> {

    return this.apiGameGamesGameIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameDetails>) => r.body as GameDetails)
    );
  }

  /**
   * Path part for operation apiGamePost
   */
  static readonly ApiGamePostPath = '/api/Game';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGamePost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiGamePost$Plain$Response(params?: {
    body?: CreateGame
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameHeader>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGamePostPath, 'post');
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
        return r as StrictHttpResponse<GameHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGamePost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiGamePost$Plain(params?: {
    body?: CreateGame
  },
  context?: HttpContext

): Observable<GameHeader> {

    return this.apiGamePost$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameHeader>) => r.body as GameHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiGamePost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiGamePost$Json$Response(params?: {
    body?: CreateGame
  },
  context?: HttpContext

): Observable<StrictHttpResponse<GameHeader>> {

    const rb = new RequestBuilder(this.rootUrl, GameService.ApiGamePostPath, 'post');
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
        return r as StrictHttpResponse<GameHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiGamePost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiGamePost$Json(params?: {
    body?: CreateGame
  },
  context?: HttpContext

): Observable<GameHeader> {

    return this.apiGamePost$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<GameHeader>) => r.body as GameHeader)
    );
  }

}
