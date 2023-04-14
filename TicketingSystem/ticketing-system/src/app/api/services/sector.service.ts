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
   * Path part for operation apiSectorGameidGet
   */
  static readonly ApiSectorGameidGetPath = '/api/Sector/{gameid}';

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSectorGameidGet$Plain()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameidGet$Plain$Response(params: {
    gameid: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SectorHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SectorService.ApiSectorGameidGetPath, 'get');
    if (params) {
      rb.path('gameid', params.gameid, {});
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
   * To access the full response (for headers, for example), `apiSectorGameidGet$Plain$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameidGet$Plain(params: {
    gameid: number;
  },
  context?: HttpContext

): Observable<Array<SectorHeader>> {

    return this.apiSectorGameidGet$Plain$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SectorHeader>>) => r.body as Array<SectorHeader>)
    );
  }

  /**
   * This method provides access to the full `HttpResponse`, allowing access to response headers.
   * To access only the response body, use `apiSectorGameidGet$Json()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameidGet$Json$Response(params: {
    gameid: number;
  },
  context?: HttpContext

): Observable<StrictHttpResponse<Array<SectorHeader>>> {

    const rb = new RequestBuilder(this.rootUrl, SectorService.ApiSectorGameidGetPath, 'get');
    if (params) {
      rb.path('gameid', params.gameid, {});
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
   * To access the full response (for headers, for example), `apiSectorGameidGet$Json$Response()` instead.
   *
   * This method doesn't expect any request body.
   */
  apiSectorGameidGet$Json(params: {
    gameid: number;
  },
  context?: HttpContext

): Observable<Array<SectorHeader>> {

    return this.apiSectorGameidGet$Json$Response(params,context).pipe(
      map((r: StrictHttpResponse<Array<SectorHeader>>) => r.body as Array<SectorHeader>)
    );
  }

}
