# Ruby Track

# Tests

## Customizing Test Reporting

If you want color, execute the tests with:

```bash
$ ruby <filename_test.rb> -p
```

If you want to see the test names, execute the tests with:

```bash
$ ruby <filename_tests.rb> -v
```

If you would like to run only one test, you can specify one or a group with regular expression style matching.

```bash
$ ruby <filename_tests.rb> -n /empty/
```

You can combine the options as well.

## Disabling all skips

To disable all skips without changing the test file, you can run it using the lib `disable_skip`.

```bash
$ ruby -I../lib -rdisable_skip <filename_test.rb>
```
