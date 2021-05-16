import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EMPTY, Observable } from 'rxjs';
import { catchError, map } from 'rxjs/operators';
import { environment } from 'src/environments/environment';
import { Anuncio } from '../models/Anuncio';
import { MensagemService } from './mensagem.service';

@Injectable({
  providedIn: 'root'
})
export class AnuncioService {

  baseURL = `${environment.mainUrlAPI}anuncio`;

  constructor(
    private http: HttpClient,
      private mensagemServico: MensagemService
  ) { }

  getAll(): Observable<Anuncio[]> {
    return this.http.get<Anuncio[]>(this.baseURL).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  getById(id: number): Observable<Anuncio> {
    const url = `${this.baseURL}/${id}`;
    return this.http.get<Anuncio>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  put(anuncio: Anuncio): Observable<Anuncio> {
    const url = `${this.baseURL}/${anuncio.id}`;
    return this.http.put<Anuncio>(url, anuncio).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  post(anuncio: Anuncio): Observable<Anuncio> {
    return this.http.post<Anuncio>(this.baseURL, anuncio).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<Anuncio> {
    const url = `${this.baseURL}/${id}`;
    return this.http.delete<Anuncio>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  GetAllAnunciosByNome(nome: string): Observable<Anuncio[]>{
    const url = `${this.baseURL}/nome=${nome}`;
    //console.log(url)
    return this.http.get<Anuncio[]>(url).pipe(
        map((obj) => obj),
        catchError((e) => this.errorHandler(e))
      );
  }

  GetAllAnunciosByData(dataI: Date, dataF: Date): Observable<Anuncio[]>{
    const url = `${this.baseURL}/di=${dataI.toJSON()}/df=${dataF.toJSON()}`;
    console.log(url)
    return this.http.get<Anuncio[]>(url).pipe(
        map((obj) => obj),
        catchError((e) => this.errorHandler(e))
      );
  }

  GetAllAnunciosByPesquisa(nome: string, dataI: Date, dataF: Date): Observable<Anuncio[]>{
    const url = `${this.baseURL}/nome=${nome}/di=${dataI.toJSON()}/df=${dataF.toJSON()}`;
    console.log(url)
    return this.http.get<Anuncio[]>(url).pipe(
        map((obj) => obj),
        catchError((e) => this.errorHandler(e))
      );
  }

  errorHandler(e: any): Observable<any> {
    this.mensagemServico.showMessage('Ocorreu um erro com o módulo Anuncio!', true);
    return EMPTY;
  }
}
