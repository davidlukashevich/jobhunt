import React from 'react';
import { FaFacebook, FaTwitter, FaInstagram, FaLinkedin } from 'react-icons/fa';
import './index.css';
import Container from '../Container/Container';

const Footer: React.FC = () => {
  return (
    <footer className="footer">
      <Container>
        <div className="footer-content">
            <div className="footer-section about">
            <h3>About Us</h3>
            <p>Connecting tech talent with amazing job opportunities. Join us and find your ideal career path today!</p>
            </div>

            <div className="footer-section links">
            <h3>Quick Links</h3>
            <ul>
                <li><a href="/about" className="footer-link">About Us</a></li>
                <li><a href="/contact" className="footer-link">Contact</a></li>
                <li><a href="/privacy" className="footer-link">Privacy Policy</a></li>
            </ul>
            </div>

            <div className="footer-section social">
            <h3>Follow Us</h3>
            <div className="social-icons">
                <a href="https://facebook.com" target="_blank" rel="noopener noreferrer"><FaFacebook /></a>
                <a href="https://twitter.com" target="_blank" rel="noopener noreferrer"><FaTwitter /></a>
                <a href="https://instagram.com" target="_blank" rel="noopener noreferrer"><FaInstagram /></a>
                <a href="https://linkedin.com" target="_blank" rel="noopener noreferrer"><FaLinkedin /></a>
            </div>
            </div>
        </div>
        <div className="footer-bottom">
            <p>&copy; 2024 JobHunt. All rights reserved.</p>
        </div>
      </Container>
    </footer>
  );
};

export default Footer;