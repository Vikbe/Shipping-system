import React, { Component } from 'react';
import { TabContent, TabPane, Col, Row, Button, Form, FormGroup, Label, Input, FormText, Nav, NavItem, NavLink, Spinner} from 'reactstrap';
import classnames from 'classnames'; 
import { InfoRow} from './InfoRow'

export class NegotiatedRate extends Component {
  //static displayName = Counter.name;

  constructor (props) {
    super(props);
      this.state = {
          activeTab: '1', 
          FormData: {
              NameFrom: 'Frank Johnsson', 
              AddressFrom: '4-60 Langille Dr',
              CityFrom: 'Fredericton', 
              StateFrom: 'NB', 
              ZipFrom: 'E3C0M8', 
              CountryFrom: 'CA', 
              PhoneFrom: '1234567890', 
              NameTo: 'Billy Johnsson',
              AddressTo: '500 St. George St',
              CityTo: 'Moncton',
              StateTo: 'NB',
              ZipTo: 'E1C1Y3',
              CountryTo: 'CA',
              PhoneTo: '1234567890'
          }, 
          fetching: false
      };
      this.toggle = this.toggle.bind(this); 
      this.handleChange = this.handleChange.bind(this);  
      this.getRates = this.getRates.bind(this); 
  }


     handleChange(event) {
        event.persist();

        this.setState((prevState, props) => {
            let newState = { ...this.state };
            newState.FormData[event.target.name] = event.target.value;
            return newState;
        });
    }

    getRates() {

        this.setState({
            fetching: true
        });

        fetch('api/GetNegotiatedRates', {
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(this.state.FormData),
            cache: "no-store",
            credentials: "same-origin",
            method: "post"
        }).then(response => response.json())
            .then(json => this.setState({
                activeTab: '4',
                shipmentResults: json.shipmentResponse.shipmentResults,
                fetching: false
            }));



    }

   
  toggle(tab) {
    if (this.state.activeTab !== tab) {
        this.setState({
            activeTab: tab
        });
    }
  }

  render () {
    return (
        <div>
            <Nav tabs>
                <NavItem>
                    <NavLink
                        className={classnames({ active: this.state.activeTab === '1' })}
                        onClick={() => { this.toggle('1'); }}
                    >
                        From
            </NavLink>
                </NavItem>
                <NavItem>
                    <NavLink
                        className={classnames({ active: this.state.activeTab === '2' })}
                        onClick={() => { this.toggle('2'); }}
                    >
                        To
            </NavLink>
                </NavItem> 
                <NavItem>
                    <NavLink
                        className={classnames({ active: this.state.activeTab === '3' })}
                        onClick={() => { this.toggle('3'); }}
                    >
                        Package
            </NavLink>
                </NavItem> 
                <NavItem>
                    <NavLink
                        className={classnames({ active: this.state.activeTab === '4' })}
                        
                    >
                        Result
            </NavLink>
                </NavItem>
            </Nav>
            <TabContent activeTab={this.state.activeTab}>
                <TabPane tabId="1">
                    <Form>

                        <FormGroup>
                            <Label for="NameFrom">Name</Label>
                            <Input type="text" name="NameFrom" id="NameFrom" placeholder="Billy Bob Johnsson" value={this.state.FormData.NameFrom} onChange={this.handleChange}/>
                        </FormGroup>
                        <FormGroup>
                            <Label for="AddressFrom">Address</Label>
                            <Input type="text" name="AddressFrom" id="AddressFrom" placeholder="1234 Main St" value={this.state.FormData.AddressFrom} onChange={this.handleChange} />
                        </FormGroup>

                        <Row form>
                            <Col md={4}>
                                <FormGroup>
                                    <Label for="CityFrom">City</Label>
                                    <Input type="text" name="CityFrom" id="CityFrom" value={this.state.FormData.CityFrom} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                            <Col md={4}>
                                <FormGroup>
                                    <Label for="StateFrom">State</Label>
                                    <Input type="text" name="StateFrom" id="StateFrom" value={this.state.FormData.StateFrom} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="ZipFrom">Zip</Label>
                                    <Input type="text" name="ZipFrom" id="ZipFrom" value={this.state.FormData.ZipFrom} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col> 
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="CountryFrom">Country code</Label>
                                    <Input type="text" name="CountryFrom" id="CountryFrom" value={this.state.FormData.CountryFrom} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                        </Row>
                        <FormGroup>
                            <Label for="PhoneFrom">Phone</Label>
                            <Input type="text" name="PhoneFrom" id="PhoneFrom" placeholder="" value={this.state.FormData.PhoneFrom} onChange={this.handleChange}/>
                        </FormGroup>
                        <Button color="primary" onClick={() => { this.toggle('2'); }}>Next</Button>
                    </Form> 
                </TabPane>
                <TabPane tabId="2">
                    <Form>

                        <FormGroup>
                            <Label for="NameTo">Name</Label>
                            <Input type="text" name="NameTo" id="NameTo" placeholder="Billy Bob Johnsson" value={this.state.FormData.NameTo} onChange={this.handleChange} />
                        </FormGroup>
                        <FormGroup>
                            <Label for="AddressTo">Address</Label>
                            <Input type="text" name="AddressTo" id="AddressTo" placeholder="1234 Main St" value={this.state.FormData.AddressTo} onChange={this.handleChange} />
                        </FormGroup>

                        <Row form>
                            <Col md={4}>
                                <FormGroup>
                                    <Label for="CityTo">City</Label>
                                    <Input type="text" name="CityTo" id="CityTo" value={this.state.FormData.CityTo} onChange={this.handleChange} />
                                </FormGroup>
                            </Col>
                            <Col md={4}>
                                <FormGroup>
                                    <Label for="StateTo">State</Label>
                                    <Input type="text" name="StateTo" id="StateTo" value={this.state.FormData.StateTo} onChange={this.handleChange} />
                                </FormGroup>
                            </Col>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="ZipTo">Zip</Label>
                                    <Input type="text" name="ZipTo" id="ZipTo" value={this.state.FormData.ZipTo} onChange={this.handleChange} />
                                </FormGroup>
                            </Col>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="CountryTo">Country code</Label>
                                    <Input type="text" name="CountryTo" id="CountryTo" value={this.state.FormData.CountryTo} onChange={this.handleChange} />
                                </FormGroup>
                            </Col>
                        </Row>
                        <FormGroup>
                            <Label for="PhoneTo">Phone</Label>
                            <Input type="text" name="PhoneTo" id="PhoneTo" placeholder="" value={this.state.FormData.PhoneTo} onChange={this.handleChange} />
                        </FormGroup>
                        <Button color="primary" onClick={() => { this.toggle('3'); }}>Next</Button>
                    </Form> 
                </TabPane> 
                <TabPane tabId="3">
                    <Form>

                        <Row form>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="Weight">Weight</Label>
                                    <Input type="number" name="Weight" id="Weight" value={this.state.FormData.Weight} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                        </Row>
                        <Row form>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="Length">Length</Label>
                                    <Input type="number" name="Length" id="Length" value={this.state.FormData.Length} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="Width">Width</Label>
                                    <Input type="number" name="Width" id="Width" value={this.state.FormData.Width} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                            <Col md={2}>
                                <FormGroup>
                                    <Label for="Height">Height</Label>
                                    <Input type="number" name="Height" id="Height" value={this.state.FormData.Height} onChange={this.handleChange}/>
                                </FormGroup>
                            </Col>
                           
                        </Row>
                        <FormGroup>
                            <Label for="PackageDescription">Description</Label>
                            <Input type="textarea" name="PackageDescription" id="PackageDescription" placeholder="" value={this.state.FormData.PackageDescription} onChange={this.handleChange}/>
                        </FormGroup>
                        <Button color="primary" onClick={this.getRates}>Get rates</Button>
                    </Form> 
                </TabPane> 
                <TabPane tabId="4">
                    <Form>
                        {(this.state.fetching) ? 
                            <Spinner type="grow" color="dark" />
                            : (this.state.shipmentResults) ?
                            <div>
                                    <br/>
                                    <InfoRow Title="Public rate" Value={this.state.shipmentResults.shipmentCharges.transportationCharges.monetaryValue + ' ' + this.state.shipmentResults.shipmentCharges.transportationCharges.currencyCode} /> 
                                    <InfoRow Title="Negotiated rate" Value={this.state.shipmentResults.negotiatedRateCharges.totalCharge.monetaryValue + ' ' + this.state.shipmentResults.negotiatedRateCharges.totalCharge.currencyCode} />
                                    <InfoRow Title="Shipment-ID" Value={this.state.shipmentResults.shipmentIdentificationNumber} /> 
                                 <Button color="primary" href={"api/invoice/pdf/" + this.state.shipmentResults.shipmentIdentificationNumber}>View PDF invoice</Button>
                                    
                            </div> 
                                : null
                        }
                        
                    </Form>
                </TabPane>
            </TabContent>




          
            </div>
    );
  }
}
