import React from 'react';
import PropTypes from 'prop-types';
import {
  makeStyles,
  createMuiTheme,
  ThemeProvider,
} from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import Typography from '@material-ui/core/Typography';
import TextField from '@material-ui/core/TextField';
import FormControlLabel from '@material-ui/core/FormControlLabel';
import Checkbox from '@material-ui/core/Checkbox';
import Link from '@material-ui/core/Link';
import Grid from '@material-ui/core/Grid';
import { amber } from '@material-ui/core/colors';

const useStyles = makeStyles((theme) => ({
  paper: {
    margin: theme.spacing(2),
  },
  title: {
    margin: theme.spacing(2, 2, 0, 2),
  },
  form: {
    margin: theme.spacing(2, 2),
  },
  submit: {
    margin: theme.spacing(3, 0, 2),
  },
}));

const theme = createMuiTheme({
  palette: {
    primary: { main: amber[800] },
  },
});

export default function SignUp(props) {
  const classes = useStyles();
  const { onClose, open } = props;

  const handleClose = () => {
    onClose();
  };

  return (
    <Dialog
      className={classes.paper}
      onClose={handleClose}
      aria-labelledby="simple-dialog-title"
      open={open}
    >
      <Typography
        align="center"
        component="h1"
        variant="h4"
        className={classes.title}
      >
        Read Comment Create
      </Typography>
      <form className={classes.form} noValidate>
        <ThemeProvider theme={theme}>
          <TextField
            variant="outlined"
            margin="normal"
            required
            fullWidth
            id="email"
            label="Email Address"
            name="email"
            autoComplete="email"
            autoFocus
            color="primary"
          />
          <TextField
            variant="outlined"
            margin="normal"
            required
            fullWidth
            name="password"
            label="Password"
            type="password"
            id="password"
            color="primary"
            autoComplete="current-password"
          />
          <FormControlLabel
            control={<Checkbox value="remember" color="primary" />}
            label="Remember me"
          />
          <Button
            type="submit"
            fullWidth
            variant="contained"
            color="primary"
            className={classes.submit}
          >
            Sign In
          </Button>
          <Grid container>
            <Grid item xs>
              <Link href="#" variant="body2" color="inherit">
                Forgot password?
              </Link>
            </Grid>
            <Grid item>
              <Link href="#" variant="body2" color="inherit">
                {'Sign Up'}
              </Link>
            </Grid>
          </Grid>
        </ThemeProvider>
      </form>
    </Dialog>
  );
}

SignUp.propTypes = {
  onClose: PropTypes.func.isRequired,
  open: PropTypes.bool.isRequired,
  selectedValue: PropTypes.string.isRequired,
};
