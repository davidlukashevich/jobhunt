import React from 'react';
import './index.css';
import Container from '../../components/Container/Container';
import Card from '../../components/Card/Card'; // Import the card component

const Main: React.FC = () => {
    return (
        <div className='main'>
            <Container>
                <h2 className='main-title'>JobHunt</h2>
                <div className='search-section'>
                    <input type="text" placeholder="Search for jobs..." className='search-bar' />
                    <button className='search-btn'>Search</button>
                </div>
                <div className='filter-section'>
                    <button className='filter-btn'>Frontend</button>
                    <button className='filter-btn'>Backend</button>
                    <button className='filter-btn'>JavaScript</button>
                    <button className='filter-btn'>TypeScript</button>
                    <button className='filter-btn'>UI/UX</button>
                    <button className='filter-btn'>DevOps</button>
                    <button className='filter-btn'>Business Analytics</button>
                    <button className='filter-btn'>Cyber Security</button>
                    <button className='filter-btn'>HR</button>
                    <button className='filter-btn'>Product Owner</button>
                </div>
                <div className='card-container'>
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                    <Card />
                </div>
            </Container>
        </div>
    );
};

export default Main;