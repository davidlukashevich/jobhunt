import React from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Header from './components/Header/Header';
import Main from './pages/Main/Main';
import AuthPage from './pages/Auth/AuthPage';
import JobDetails from './pages/JobDetails/JobDetails';

function App() {
  return (
    <BrowserRouter>
      <div className="App">
        <Header/>
          <Routes>
            <Route path='/' Component={Main}/>
            <Route path='/auth' Component={AuthPage} />
            <Route path='/job/:id' element={<JobDetails />} />
          </Routes>
      </div>
    </BrowserRouter>
  );
}

export default App;
