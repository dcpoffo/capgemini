import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Cliente } from '../models/Cliente';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class ClienteService {

  baseURL = `${environment.mainUrlAPI}cliente`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<Cliente> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<Cliente>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(cliente: Cliente): Observable<Cliente> {
    const url = `${this.baseURL}/${cliente.id}`;
    return this.http.put<Cliente>(url, cliente).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(cliente: Cliente): Observable<Cliente> {
    return this.http.post<Cliente>(this.baseURL, cliente).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<Cliente> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<Cliente>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Cliente!', true);
    return EMPTY;
  }

}
