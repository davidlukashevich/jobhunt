import React, { useContext, useState } from 'react';
import { Navigate, useNavigate } from 'react-router';
import userApi from '../../api/userApi';
import UserDataContext from '../UserDataMode/UserDataMode';
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
  const [errorPassword, setErrorPassword] = useState(false);
  const [errorLogin, setErrorLogin] = useState(false);
  const context = useContext(UserDataContext);
  const [isAuth, setIsAuth] = useState(false);

  if (!context) {
    throw new Error('Component must be used within a Provider');
  }

  const { changeUserId, changeRole } = context;


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
      userApi.userLogin(loginForm.email, loginForm.password).then(data => {
        setErrorLogin(false)
        changeUserId(data.userId)
        changeRole(data.userRoles);
        setIsAuth(true)
      }).catch(err => {
        setErrorLogin(true)
      });

    } else {
      if (signUpForm.password !== signUpForm.confirmPassword) {
        setErrorPassword(true);
        return
      }

      userApi.userRegister(signUpForm.email, signUpForm.password, signUpForm.username, signUpForm.userType).then(data => {
        setErrorPassword(false);
        setFormType('login')
      });
    }
  };

  if (isAuth) {
    return <div><Navigate to={'/myprofile'} /></div>
  }

  return (
    <div className='auth-form'>
      <div className="auth-form-switch">
        <button
          onClick={() => setFormType('login')}
          className={formType === 'login' ? 'active' : 'login-btn'}
        >
          Log In
        </button>
        <button
          onClick={() => setFormType('signup')}
          className={formType === 'signup' ? 'active' : 'signup-btn'}
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
            pattern='^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*_])[A-Za-z\d!@#$%^&*_]{6,20}$'
            title='The password must contain at least one uppercase letter, one lowercase letter, one number, and one special character (!@#$%^&*), and be between 6 and 20 characters long.'
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
                pattern='^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!@#$%^&*_])[A-Za-z\d!@#$%^&*_]{6,20}$'
                required
              />
            </div>
          </>
        )}

        <button type="submit" className="submit-btn">
          {formType === 'login' ? 'Log In' : 'Sign Up'}
        </button>
        {formType === 'login' && errorLogin && <p className='error'>Wrong email or password</p>}
        {formType === 'signup' && errorPassword && <p className='error'>The passwords do not match</p>}
      </form>
    </div>
  );
};

export default Form;