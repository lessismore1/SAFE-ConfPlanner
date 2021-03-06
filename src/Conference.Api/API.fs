module Conference.Api.API

open Domain.Model

type QueryParameter =
  | Conference of ConferenceId
  | Organizers
  | Conferences

type QueryResult =
  | Conference of Conference
  | Conferences of (ConferenceId * string) list
  | Organizers of Organizers
  | ConferenceNotFound
