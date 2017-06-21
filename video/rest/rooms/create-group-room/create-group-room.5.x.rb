# Download the Ruby helper library from twilio.com/docs/libraries/ruby
require 'twilio-ruby'

# Get your Account Sid and Auth Token from https://www.twilio.com/console
account_sid = 'ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX'
auth_token = 'your_auth_token'

client = Twilio::REST::Client.new account_sid, auth_token

group_room = client.video.rooms.create(
  unique_name: 'DailyStandup',
  type: 'group',
  record_participants_on_connect: true,
  status_callback: 'http://example.org'
)

puts group_room
