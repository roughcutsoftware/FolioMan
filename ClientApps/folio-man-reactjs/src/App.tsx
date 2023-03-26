import React from 'react';
// import logo from './logo.svg';
import './App.css';
import { useState, useEffect } from "react";
import 'bootstrap/dist/css/bootstrap.min.css';
// import "./styles.css";

// type resultProps = {
//   email: string;
//   gender: string;
// };

// export interface IWeatherInfo {
//   date:         Date;
//   temperatureC: number;
//   temperatureF: number;
//   summary:      string;
// }
type IWeatherInfo = {
  date:         Date;
  temperatureC: number;
  temperatureF: number;
  summary:      string;
};

function App() {
  const [result, setResult] = useState<IWeatherInfo[]>([]);

  useEffect(() => {
    const api = async () => {
      const data = await fetch("http://local.cerebralskyz.com/portmgr/WeatherForecast/", {
        method: "GET"
      });
      const jsonData = await data.json();
      console.log(jsonData);
      // setResult(jsonData.results);
      setResult(jsonData);
    };

    api();
  }, []);

  return (
    <div className="container-fluid">
      {/* <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.tsx</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>
      </header> */}
      <h3>
      {result.map((item) => {
          return (
            <div className="row border border-primary">
              <span className="col-sm text-left border border-secondary">{item.date.toString()}</span>
              <span className="col-sm text-left border border-secondary">{item.summary}</span>
              <span className="col-sm text-left border border-secondary">{item.temperatureF.toString()}</span>
              <span className="col-sm text-left border border-secondary">{item.temperatureC.toString()}</span>
            </div>
          );
        })}
      </h3>
    </div>
  );
}

export default App;
