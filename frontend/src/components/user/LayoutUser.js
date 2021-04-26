import NavbarUser from "./NavbarUser";

function LayoutUser(props) {
  return (
    <>
      <NavbarUser />
      {props.children}
    </>
  );
}

export default LayoutUser;
