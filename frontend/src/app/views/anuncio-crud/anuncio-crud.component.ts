import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/templante/header/header.service';

@Component({
  selector: 'app-anuncio-crud',
  templateUrl: './anuncio-crud.component.html',
  styleUrls: ['./anuncio-crud.component.scss']
})
export class AnuncioCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Anuncios',
      icon: 'campaign',
      routeUrl: '/anuncios'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/anuncios/create']);
  }

}
