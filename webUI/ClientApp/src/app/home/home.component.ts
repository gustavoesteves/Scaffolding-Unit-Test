import { Component } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  Result: number = null;
  Api: string = "https://localhost:44364/api/Calculator/GetCalc/";

  constructor(private http: HttpClient) { }

  Calc(FirstNumber: number, SecondNumber: number, Calc: string) {
    this.GetCalc(FirstNumber, SecondNumber, Calc).subscribe((result: any) => {
      this.Result = result;
    });
  }

  GetCalc(FirstNumber: number, SecondNumber: number, Calc: string): Observable<HttpResponse<Object>> {
    return this.http.get<HttpResponse<Object>>(this.Api + FirstNumber + "/" + SecondNumber + "/" + Calc).pipe();
  }
}
