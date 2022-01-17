import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, retry, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {

  private service_url: string = 'https://localhost:44342/api/';
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json'
    })
  } 

  constructor(private _httpClient: HttpClient) { }

  getformData() {
    return this._httpClient.get<any>(this.service_url + 'Form')
    .pipe(
      retry(1),
      catchError(this.handleError)
    )
  }

  getformByIdData(formId: number) {
    return this._httpClient.get<any>(this.service_url + 'Form/' + formId)
      .pipe(
        retry(1),
        catchError(this.handleError)
      )
  }

  handleError(error: any) {
    let errorMessage = '';
    if(error.error instanceof ErrorEvent) {
      // Get client-side error
      errorMessage = error.error.message;
    } else {
      // Get server-side error
      errorMessage = `Error Code: ${error.status}\nMessage: ${error.message}`;
    }
    window.alert(errorMessage);
    return throwError(errorMessage);
 }
}
