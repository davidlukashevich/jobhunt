import React, { useState } from 'react';
import './index.css';

interface LoginForm {
  email: string;
  password: string;
}

interface SignUpForm extends LoginForm {
  username: string;
  confirmPassword: string;
  userType: 'employee' | 'employer';
  companyName?: string;
  companyAddress?: string;
}

type FormType = 'login' | 'signup';

const Form: React.FC = () => {
  const [formType, setFormType] = useState<FormType>('login');
  const [userType, setUserType] = useState<'employee' | 'employer'>('employee');

  const [loginForm, setLoginForm] = useState<LoginForm>({
    email: '',
    password: '',
  });

  const [signUpForm, setSignUpForm] = useState<SignUpForm>({
    email: '',
    password: '',
    username: '',
    confirmPassword: '',
    userType: 'employee',
  });

  const handleInputChange = (
    e: React.ChangeEvent<HTMLInputElement>,
    form: 'login' | 'signup'
  ) => {
    const { name, value } = e.target;

    if (form === 'login') {
      setLoginForm({
        ...loginForm,
        [name]: value,
      });
    } else {
      setSignUpForm({
        ...signUpForm,
        [name]: value,
      });
    }
  };

  const handleUserTypeChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { value } = e.target;
    setUserType(value as 'employee' | 'employer');
    setSignUpForm({
      ...signUpForm,
      userType: value as 'employee' | 'employer',
    });
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    if (formType === 'login') {
      console.log('Logging in with: ', loginForm);
    } else {
      console.log('Signing up with: ', signUpForm);
    }
  };

  return (
    <div className='auth-form'>
      <div className="auth-form-switch">
        <button 
            onClick={() => setFormType('login')}
            className={formType === 'login' ? 'active' : ''}
        >
          Log In
        </button>
        <button 
            onClick={() => setFormType('signup')}
            className={formType === 'signup' ? 'active' : ''}
        >
          Sign Up
        </button>
      </div>

      {formType === 'signup' && (
        <div className="user-type-selection">
          <label>Are you an employee or an employer?</label>
          <div className="radio-group">
            <label>
              <input
                type="radio"
                name="userType"
                value="employee"
                checked={userType === 'employee'}
                onChange={handleUserTypeChange}
              /> Employee
            </label>
            <label>
              <input
                type="radio"
                name="userType"
                value="employer"
                checked={userType === 'employer'}
                onChange={handleUserTypeChange}
              /> Employer
            </label>
          </div>
        </div>
      )}

      <form onSubmit={handleSubmit}>
        <div>
          <label>Email:</label>
          <input
            type="email"
            name="email"
            className='auth-form-input'
            value={formType === 'login' ? loginForm.email : signUpForm.email}
            onChange={(e) => handleInputChange(e, formType)}
            required
          />
        </div>
        <div>
          <label>Password:</label>
          <input
            type="password"
            name="password"
            className='auth-form-input'
            value={
              formType === 'login' ? loginForm.password : signUpForm.password
            }
            onChange={(e) => handleInputChange(e, formType)}
            required
          />
        </div>

        {formType === 'signup' && (
          <>
            <div>
              <label>Username:</label>
              <input
                type="text"
                name="username"
                className='auth-form-input'
                value={signUpForm.username}
                onChange={(e) => handleInputChange(e, 'signup')}
                required
              />
            </div>
            <div>
              <label>Confirm Password:</label>
              <input
                type="password"
                name="confirmPassword"
                className='auth-form-input'
                value={signUpForm.confirmPassword}
                onChange={(e) => handleInputChange(e, 'signup')}
                required
              />
            </div>

            {userType === 'employer' && (
              <>
                <div>
                  <label>Company Name:</label>
                  <input
                    type="text"
                    name="companyName"
                    className='auth-form-input'
                    value={signUpForm.companyName || ''}
                    onChange={(e) => handleInputChange(e, 'signup')}
                    required
                  />
                </div>
                <div>
                  <label>Company Address:</label>
                  <input
                    type="text"
                    name="companyAddress"
                    className='auth-form-input'
                    value={signUpForm.companyAddress || ''}
                    onChange={(e) => handleInputChange(e, 'signup')}
                    required
                  />
                </div>
              </>
            )}
          </>
        )}

        <button type="submit" className="submit-btn">
          {formType === 'login' ? 'Log In' : 'Sign Up'}
        </button>
      </form>
    </div>
  );
};

export default Form;