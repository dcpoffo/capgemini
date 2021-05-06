import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Cliente } from 'src/app/models/Cliente';
import { ClienteService } from 'src/app/services/Cliente.service';
import { MensagemService } from 'src/app/services/mensagem.service';

@Component({
  selector: 'app-cliente-update',
  templateUrl: './cliente-update.component.html',
  styleUrls: ['./cliente-update.component.scss']
})
export class ClienteUpdateComponent implements OnInit {

  clienteForm = new FormGroup({
    nome: new FormControl('', [Validators.required, Validators.minLength(3)]),
  });

  cliente: Cliente = {
    nome: ''
  };

  constructor(
    private clienteServico: ClienteService,
    private mensagemServico: MensagemService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    const id = +this.route.snapshot.paramMap.get('id');
    this.clienteServico.getById(id).subscribe((cliente) => {
      this.cliente = cliente;
    });
  }

  atualizar(): void {
    this.clienteServico.put(this.cliente).subscribe(() => {
      this.mensagemServico.showMessage('Cadastro atualizado com sucesso!');
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
