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

import { TeamHeader } from '../models/team-header';

@Injectable({
  providedIn: 'root',
})
export class TeamService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiTeamGet
   */
  static readonly ApiTeamGetPath = '/api/Team';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamGet$Plain$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<TeamHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<TeamHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamGet$Plain(params?: {
  },
  context?: HttpContext

): Observable<Array<TeamHeader>> {

    return this.apiTeamGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<TeamHeader>>) => r.body as Array<TeamHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamGet$Json$Response(params?: {
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<TeamHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamGetPath, 'get');
    if (params) {
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<Array<TeamHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamGet$Json(params?: {
  },
  context?: HttpContext

): Observable<Array<TeamHeader>> {

    return this.apiTeamGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<TeamHeader>>) => r.body as Array<TeamHeader>)
    );
  }

  /**
   * Path part for operation apiTeamPost
   */
  static readonly ApiTeamPostPath = '/api/Team';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamPost$Plain()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTeamPost$Plain$Response(params?: {
    body?: TeamHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<TeamHeader>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamPostPath, 'post');
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
        return r as StrictHttpResponse<TeamHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamPost$Plain$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTeamPost$Plain(params?: {
    body?: TeamHeader
  },
  context?: HttpContext

): Observable<TeamHeader> {

    return this.apiTeamPost$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<TeamHeader>) => r.body as TeamHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamPost$Json()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTeamPost$Json$Response(params?: {
    body?: TeamHeader
  },
  context?: HttpContext

): Observable<StrictHttpResponse<TeamHeader>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamPostPath, 'post');
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
        return r as StrictHttpResponse<TeamHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamPost$Json$Response()` instead.
   *
   * This method sends `application/*+json` and handles request body of type `application/*+json`.
   */
  apiTeamPost$Json(params?: {
    body?: TeamHeader
  },
  context?: HttpContext

): Observable<TeamHeader> {

    return this.apiTeamPost$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<TeamHeader>) => r.body as TeamHeader)
    );
  }

  /**
   * Path part for operation apiTeamTeamIdGet
   */
  static readonly ApiTeamTeamIdGetPath = '/api/Team/{teamId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamTeamIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdGet$Plain$Response(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<TeamHeader>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamTeamIdGetPath, 'get');
    if (params) {
      rb.path('teamId', params.teamId, {});
    }

    return this.http.request(rb.build({
      responseType: 'text',
      accept: 'text/plain',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<TeamHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamTeamIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdGet$Plain(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<TeamHeader> {

    return this.apiTeamTeamIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<TeamHeader>) => r.body as TeamHeader)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamTeamIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdGet$Json$Response(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<TeamHeader>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamTeamIdGetPath, 'get');
    if (params) {
      rb.path('teamId', params.teamId, {});
    }

    return this.http.request(rb.build({
      responseType: 'json',
      accept: 'text/json',
      context: context
    })).pipe(
      filter((r: any) => r instanceof HttpResponse),
      map((r: HttpResponse<any>) => {
        return r as StrictHttpResponse<TeamHeader>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiTeamTeamIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdGet$Json(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<TeamHeader> {

    return this.apiTeamTeamIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<TeamHeader>) => r.body as TeamHeader)
    );
  }

  /**
   * Path part for operation apiTeamTeamIdDelete
   */
  static readonly ApiTeamTeamIdDeletePath = '/api/Team/{teamId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiTeamTeamIdDelete()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdDelete$Response(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<void>> {

    const rb = new RequestBuilder(this.rootUrl, TeamService.ApiTeamTeamIdDeletePath, 'delete');
    if (params) {
      rb.path('teamId', params.teamId, {});
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
   * To access the full response (for headers, for example), `apiTeamTeamIdDelete$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiTeamTeamIdDelete(params: {
    teamId: number;
  },
  context?: HttpContext

): Observable<void> {

    return this.apiTeamTeamIdDelete$Response(params,context).pipe(
      map((r: StrictHttpResponse<void>) => r.body as void)
    );
  }

}
