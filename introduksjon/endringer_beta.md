# Endringer 201802

## Generelt

Denne versjonen av KL06 inneholder mindre endringer knyttet til merkelapp-koblinger og hjelpedata. I tillegg introduserer vi nye måter å kalle de ulike versjonene på.

Versjon 201311 er faset ut, og kan ikke lenger nås.


### Kontraktsendringer

####Merkelapper

- Merkelappkoblinger er utvidet med gyldighetsperiode. Mer info finnes [her](https://www.gitbook.com/book/kl06-doc/kl06-public/edit#/edit/beta/appendix_a.md?_k=xwozmm).

#### Hjelpedata

- Hjelpedatatypene som tidligere lå under Hjelpedata, er nå splittet ut som egne elementtyper. [her](https://www.gitbook.com/book/kl06-doc/kl06-public/edit#/edit/beta/appendix_a.md?_k=xwozmm).

### Versjonering
- I tillegg til å tilby versjonering ved bruk av query-string, tilbyr vi nå også versjonering i url og i header.

- Eksempler
  - Rest:
    - 201604
      - http://beta-data.udir.no/kl06/201604/fagtype_fellesfag
      - http://beta-data.udir.no/kl06/fagtype_fellesfag?versjon=201604
      - http://beta-data.udir.no/kl06/fagtype_fellesfag?versjon=http://psi.udir.no/kl06/2016/04
    
    - 201802
      - http://beta-data.udir.no/kl06/fagtype_fellesfag
      - http://beta-data.udir.no/kl06/201802/fagtype_fellesfag
      - http://beta-data.udir.no/kl06/fagtype_fellesfag?versjon=201802
      - http://beta-data.udir.no/kl06/fagtype_fellesfag?versjon=http://psi.udir.no/kl06/2018/02

  - Soap:
    - 201604
      - http://test-data.udir.no/kl06/v201604/soap?wsdl
      - http://beta-data.udir.no/kl06/soap_/v201604/soap
      - http://psi.udir.no/kl06/2016/04/GrepSoap/HentFagtypeFraKode
      
         {%ace edit=false, check=false %}
 
              <x:Envelope xmlns:x="http://schemas.xmlsoap.org/soap/envelope/"                 xmlns:ns="http://psi.udir.no/kl06/2016/04">
                  <x:Header/>
                  <x:Body>
                     <ns:HentFagtypeFraKode>
                        <ns:request>
                            <ns:kode>fagtype_fellesfag</ns:kode>
                        </ns:request>
                     </ns:HentFagtypeFraKode>
                  </x:Body>
             </x:Envelope>
         
        {%endace%}

   - 201802
      - http://test-data.udir.no/kl06/v201802/soap?wsdl
      - http://beta-data.udir.no/kl06/soap_/v201802/soap
      - http://psi.udir.no/kl06/2018/02/GrepSoap/HentFagtypeFraKode
      
      {%ace edit=false, check=false %}

            <x:Envelope xmlns:x="http://schemas.xmlsoap.org/soap/envelope/"                                           xmlns:ns="http://psi.udir.no/kl06/2018/02" xmlns:ns1="http://psi.udir.no/kl06/2016/04">
                <x:Header/>
                <x:Body>
                    <ns:HentFagtypeFraKode>
                        <ns:request>
                            <ns1:kode>fagtype_fellesfag</ns1:kode>
                            <ns1:valgt-spraak>nno</ns1:valgt-spraak>
                        </ns:request>
                    </ns:HentFagtypeFraKode>
                </x:Body>
            </x:Envelope>

        {%endace%}


  
- Vi tilbyr ikke versjonering på Odata og RDF/sparql
  
  



