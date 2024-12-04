import logo from './logo.svg';
import './App.css';
import LoginComponent from './components/LoginComponent/LoginComponent';

function handleClick() {
  <LoginComponent/>;
}


function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          <button onClick={handleClick}>hello</button>
        </p>
       
      </header>
    </div>
  );
}

export default App;
