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

import { SectorHeader } from '../models/sector-header';

@Injectable({
  providedIn: 'root',
})
export class SectorService extends BaseService {
  constructor(
    config: ApiConfiguration,
    http: HttpClient
  ) {
    super(config, http);
  }

  /**
   * Path part for operation apiSectorGameIdGet
   */
  static readonly ApiSectorGameIdGetPath = '/api/Sector/{gameId}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSectorGameIdGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameIdGet$Plain$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SectorHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SectorService.ApiSectorGameIdGetPath, 'get');
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
        return r as StrictHttpResponse<Array<SectorHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSectorGameIdGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameIdGet$Plain(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<Array<SectorHeader>> {

    return this.apiSectorGameIdGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SectorHeader>>) => r.body as Array<SectorHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSectorGameIdGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameIdGet$Json$Response(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SectorHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SectorService.ApiSectorGameIdGetPath, 'get');
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
        return r as StrictHttpResponse<Array<SectorHeader>>;
      })
    );
  }

  /**
   * This method provides access only to the response body.
   * To access the full response (for headers, for example), `apiSectorGameIdGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameIdGet$Json(params: {
    gameId: number;
  },
  context?: HttpContext

): Observable<Array<SectorHeader>> {

    return this.apiSectorGameIdGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SectorHeader>>) => r.body as Array<SectorHeader>)
    );
  }

}
