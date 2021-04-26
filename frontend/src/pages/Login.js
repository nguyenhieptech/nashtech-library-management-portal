import React from "react";
import { useForm } from "react-hook-form";
import LayoutAdmin from "../components/admin/LayoutAdmin";
import "./Login.css";

function Login() {
  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm();

  const onSubmit = (data) => console.log(data);

  return (
    <LayoutAdmin>
      <div className='center-form'>
        <div className='login-form'>
          <h2>Login</h2>

          <form onSubmit={handleSubmit(onSubmit)}>
            <div className='text-field'>
              <input {...register("username")} />
              <span></span>
              <label htmlFor='username'>Username</label>
            </div>
            {/* {errors.username && <span>This field is required</span>} */}

            <div className='text-field'>
              <input {...register("password", { required: true })} />
              <span></span>
              <label htmlFor='password'>Password</label>
            </div>
            {/* {errors.password && <span>This field is required</span>} */}

            <div className='forget-password'>Forget Password?</div>

            <input type='submit' value='Login' />
          </form>
        </div>
      </div>
    </LayoutAdmin>
  );
}

export default Login;
