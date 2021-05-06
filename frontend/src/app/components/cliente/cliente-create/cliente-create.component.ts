import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Cliente } from 'src/app/models/Cliente';
import { ClienteService } from 'src/app/services/Cliente.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-cliente-create',
  templateUrl: './cliente-create.component.html',
  styleUrls: ['./cliente-create.component.scss']
})
export class ClienteCreateComponent implements OnInit {

  clienteForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
  });

  cliente: Cliente = {
    nome: ''
  };

  constructor(
    private clienteServico: ClienteService,
    private mensagemServico: MensagemService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  criarCliente(): void {
    this.clienteServico.post(this.cliente).subscribe(() => {
      this.mensagemServico.showMessage('Cliente cadastrado com sucesso!')
      this.router.navigate(['/clientes']);
    });
  }

  cancelar(): void {
    this.router.navigate(['/clientes']);
  }

  public temErro = (controlName: string, errorName: string) =>{
    return this.clienteForm.controls[controlName].hasError(errorName);
  }

}
