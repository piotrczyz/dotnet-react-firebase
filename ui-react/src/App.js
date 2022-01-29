import logo from './logo.svg';
import './App.css';
import {useEffect} from "react";
import axios from "axios";

function App() {
  
  useEffect(() => {
    
      const fetchFirebaseToken = async () => {
          const token = await axios.get('https://localhost:7159/FirebaseToken')
          console.log(token.data);
      }    
      fetchFirebaseToken();
  },[]);
  
  return (
    <div className="App">
      <header className="App-header">
        Firebase Example
      </header>
      <section>
        
      </section>
    </div>
  );
}

export default App;
