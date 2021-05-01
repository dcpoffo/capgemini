import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Pessoa } from '../models/Pessoa';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class PessoaService {

  baseURL = `${environment.mainUrlAPI}pessoa`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<Pessoa[]> {
    return this.http.get<Pessoa[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<Pessoa> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<Pessoa>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(pessoa: Pessoa): Observable<Pessoa> {
    const url = `${this.baseURL}/${pessoa.id}`;
    return this.http.put<Pessoa>(url, pessoa).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(pessoa: Pessoa): Observable<Pessoa> {
    return this.http.post<Pessoa>(this.baseURL, pessoa).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<Pessoa> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<Pessoa>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Pessoa!', true);
    return EMPTY;
  }

}
