import React from 'react';

import { useState, useEffect } from 'react';
import logo from './logo.svg';
import './App.css';

import httpClient from "react-http-client"



function App() {

  const [users, setUsers] = useState();

  useEffect(() => {
    handleClick();
}, []);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        
        <table className="table table-striped" aria-labelledby="tabelLabel">
            <tbody>
                {users?.map(user =>
                    <tr key={user.guid}>
                        <td>{user.guid}</td>
                    </tr>
                )}
            </tbody>
        </table>
       
      </header>
    </div>
  );


  function handleClick() {

  

    httpClient.get("http://localhost:5007/api/User").then(function getdata(response) {
      setUsers(response);
      
      

      //console.log(response[4]["guid"])
      let users_list = [];

      const userslist = response.map((user) => {
        //console.log(user.guid);
        users_list.push(user.guid);
        
      })
      console.log(users_list);
    })
  
    // const response = fetch("http://localhost:5007/api/User").then((response) => {
    //   const data = response.json();
    //   console.log(response[4]);
    // })
   
  }
}

export default App;
