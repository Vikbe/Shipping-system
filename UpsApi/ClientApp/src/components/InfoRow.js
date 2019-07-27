import React, { Component } from 'react';
import { Col, Row, Label } from 'reactstrap';

export class InfoRow extends Component {


  constructor (props) {
    super(props);
      this.state = {
        
      };

  }






  render () {
    return (
        <Row>
            <Col md={2}>
                <Label>{this.props.Title}</Label>
            </Col>
            <Col md={2}>
                {this.props.Value}
            </Col>
        </Row> 
    );
  }
}
