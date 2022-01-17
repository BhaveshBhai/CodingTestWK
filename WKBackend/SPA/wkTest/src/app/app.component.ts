import { Component, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'wkTest';
  ColumnDefs: any;
  RowData: any = [];
  gridApi: any;
  gridColumnApi: any;
  form: any = [];

  constructor(private restAPI: AppService) {
  }

  ngOnInit(): void {
    this.ColumnDefs = [{
      headerName: '', field: 'name'
    }, {
      headerName: 'Frist Name', field: 'children.firstName'
    }, {
      headerName: 'Last Name', field: 'children.lastName'
    }, {
      headerName: 'Middle Name', field: 'children.middleName'
    }, {
      headerName: 'City Name', field: 'children.city'
    }, {
      headerName: 'Contact Number', field: 'children.contactNumber'
    }];
    this.restAPI.getformData().subscribe((data: {}) => {
      this.form = data;
    })
  }


  onChanged(params: any) {
    this.gridApi = params.gridApi;
    this.gridColumnApi = params.columnApi;
    this.restAPI.getformByIdData(params.target.value).subscribe((data: {}) => {
      this.RowData = data;
    })
      ;
    params.api.setRowData(this.RowData);
  }

}


