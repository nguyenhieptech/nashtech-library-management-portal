import NavbarAdmin from "./NavbarAdmin";

function LayoutAdmin(props) {
  return (
    <>
      <NavbarAdmin />
      {props.children}
    </>
  );
}

export default LayoutAdmin;
