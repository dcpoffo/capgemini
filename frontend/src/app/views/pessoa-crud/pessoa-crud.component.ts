import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { HeaderService } from 'src/app/components/templante/header/header.service';

@Component({
  selector: 'app-pessoa-crud',
  templateUrl: './pessoa-crud.component.html',
  styleUrls: ['./pessoa-crud.component.scss']
})
export class PessoaCrudComponent implements OnInit {

  constructor(
    private router: Router,
    private headerService: HeaderService
  ) {
    headerService.headerData = {
      title: 'Cadastro de Pessoas',
      icon: 'person',
      routeUrl: '/pessoas'
    };
  }

  ngOnInit() {
  }

  novo(): void {
    this.router.navigate(['/pessoas/create']);
  }

}
