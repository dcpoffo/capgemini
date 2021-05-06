import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/templante/header/header.service';

@Component({
  selector: 'app-cliente-crud',
  templateUrl: './cliente-crud.component.html',
  styleUrls: ['./cliente-crud.component.scss']
})
export class ClienteCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Clientes',
      icon: 'person',
      routeUrl: '/clientes'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/clientes/create']);
  }

}
